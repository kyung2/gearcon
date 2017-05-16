#include "gearcon_m.h"


#define NUM_OF_ITEMS 101
#define NUM_OF_GENLIST_DEMO_NAMES 101
#define NUM_OF_GENLIST_DEMO_LONG_TEXT 7

//함수 여기다가 선언좀 해놓기!

static Evas_Object* create_scroller(Evas_Object *parent);
static Evas_Object* create_button_view(Evas_Object *parent);
static Eina_Bool _setting_finished_cb(void *data, Elm_Object_Item *it);

void up_btn_clicked_cb(void* data);
void down_btn_clicked_cb(void* data);


typedef struct _item_data {
	int index;
	Elm_Object_Item *item;
} item_data;


	 // PC CONTROL - > PCSETTING(밝기.배터리,볼륨,와이파이,블투,전원
static char *main_menu_names[] = {
	/*** 1line styles ***/
	"밝기",
	"배터리",
	"블륨",
	"와이파이",
	"블루투스",
	"전원",
	/* do not delete below */
	NULL
};
//hyunkyunhg
/*
 * @brief Function will be operated when manipulating setting value is finished
 * @param[in] data The data to be passed to the callback function
 * @param[in] it The item to be popped from naviframe
 */

void
my_A_cb (void *data)
{
	 appdata_s *ad = data;
	   Evas_Object *bg;

	   bg = elm_bg_add(ad->nf);
	   elm_bg_color_set(bg, 66, 162, 206);
	   elm_naviframe_item_push(ad->nf, "Solid Color", NULL, NULL, bg, "empty");

//a페이지 생성코드
}
static Eina_Bool
_setting_finished_cb(void *data, Elm_Object_Item *it)
{
	appdata_s *ad = data;

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(ad->circle_genlist, EINA_TRUE);
	return EINA_TRUE;
}

static Evas_Object*
create_scroller(Evas_Object *parent)
{
	Evas_Object *scroller = elm_scroller_add(parent);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	evas_object_show(scroller);

	return scroller;
}

void
up_btn_clicked_cb(void* data)
{

}

void
down_btn_clicked_cb(void* data)
{

}



/*
 * @brief Function will be operated when button is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	elm_naviframe_item_pop(ad->nf);
}

/*
 * @brief Function will be operated when volume value is changed
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
_volume_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	char buf[PATH_MAX];
	Evas_Object *layout = data;

	/* Get Circle Object Value */
	snprintf(buf, sizeof(buf), "%.1lf", eext_circle_object_value_get(obj));
	printf("Slider value = %s\n", buf);
	elm_object_part_text_set(layout, "elm.text.slider", buf);
}


//내가 써야할 원형
/*
 * @brief Function will be operated when brightness value is changed
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
_brightness_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	int i, value;

	/* Get Circle Object Value */
	value = eext_circle_object_value_get(obj);

	for (i = 0; i < 10; ++i) {
		if (i < value)
			evas_object_color_set(ad->rect[i], 0, 255, 0, 150);
		else
			evas_object_color_set(ad->rect[i], 0, 255, 0, 75);
	}
}

/*
 * @brief Function will be operated when "Volume" menu is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
_setting_volume_cb(void *data, Evas_Object *obj, void *event_info EINA_UNUSED)
{
	char edj_path[PATH_MAX] = {0, };
	appdata_s *ad = data;
	Evas_Object *nf = ad->nf;
	Evas_Object *layout = NULL;
	Evas_Object *slider = NULL;
	Elm_Object_Item *nf_it = NULL;

	/* Unhighlight Item */
	elm_genlist_item_selected_set((Elm_Object_Item *)event_info, EINA_FALSE);

	layout = elm_layout_add(nf);
	elm_layout_file_set(layout, edj_path, "slider_layout");
	elm_object_part_text_set(layout, "elm.text.slider", "3.0");
	evas_object_show(layout);

	/* Create Circle Slider */
	slider = eext_circle_object_slider_add(layout, ad->circle_surface);

	/* Set Circle Slider Range, Value and Step */
	eext_circle_object_value_min_max_set(slider, 0.0, 15.0);
	eext_circle_object_value_set(slider, 3.0);
	eext_circle_object_slider_step_set(slider, 0.5);

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(slider, EINA_TRUE);
	evas_object_smart_callback_add(slider, "value,changed", _volume_changed_cb, layout);

	nf_it = elm_naviframe_item_push(nf, _("Slider"), NULL, NULL, layout, "empty");
	elm_naviframe_item_pop_cb_set(nf_it, _setting_finished_cb, ad);
}

/*
 * @brief Function will be operated when "Brightness" menu is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
_setting_brigteness_cb(void *data, Evas_Object *obj, void *event_info EINA_UNUSED)
{
	char edj_path[PATH_MAX] = {0, };
	appdata_s *ad = data;
	Evas_Object *nf = ad->nf;
	Evas_Object *layout = NULL;
	Evas_Object *slider = NULL;
	Evas_Object *box = NULL;
	Evas_Object *rect[10] = {NULL, };
	Elm_Object_Item *nf_it = NULL;
	int i = 0;

	/* Unhighlight Item */
	elm_genlist_item_selected_set((Elm_Object_Item *)event_info, EINA_FALSE);

	layout = elm_layout_add(nf);
	elm_layout_file_set(layout, edj_path, "slider_layout");
	evas_object_show(layout);

	box = elm_box_add(layout);
	elm_box_horizontal_set(box, EINA_TRUE);
	elm_box_padding_set(box, 3, 0);
	evas_object_show(box);

	elm_object_part_content_set(layout, "elm.swallow.content", box);

	for (i = 0; i < 10; ++i) {
		rect[i] = evas_object_rectangle_add(evas_object_evas_get(layout));
		evas_object_color_set(rect[i], 0, 255, 0, 75);
		evas_object_size_hint_min_set(rect[i], 20, 20);
		evas_object_show(rect[i]);
		elm_box_pack_end(box, rect[i]);
	}

	for (i = 0; i < 10; ++i)
		ad->rect[i] = rect[i];

	/* Create Circle Slider */
	slider = eext_circle_object_slider_add(layout, ad->circle_surface);

	/* Set Circle Slider Range, Value and Step */
	eext_circle_object_value_min_max_set(slider, 0.0, 10.0);
	eext_circle_object_value_set(slider, 0.0);
	eext_circle_object_slider_step_set(slider, 1.0);

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(slider, EINA_TRUE);
	evas_object_smart_callback_add(slider, "value,changed", _brightness_changed_cb, ad);

	nf_it = elm_naviframe_item_push(nf, _("Slider"), NULL, NULL, layout, "empty");
	elm_naviframe_item_pop_cb_set(nf_it, _setting_finished_cb, ad);
}

/*
 * @brief Function will be operated when "Information" menu is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
_setting_information_cb(void *data, Evas_Object *obj, void *event_info EINA_UNUSED)
{
	char edj_path[PATH_MAX] = {0, };
	appdata_s *ad = data;
	Evas_Object *nf = ad->nf;
	Evas_Object *layout = NULL;
	Evas_Object *label = NULL;
	Evas_Object *button = NULL;
	Evas_Object *scroller = NULL;
	Evas_Object *circle_scroller = NULL;
	Elm_Object_Item *nf_it = NULL;

	/* Unhighlight Item */
	elm_genlist_item_selected_set((Elm_Object_Item *)event_info, EINA_FALSE);


	layout = elm_layout_add(nf);
	elm_layout_file_set(layout, edj_path, "info_layout");
	evas_object_show(layout);

	scroller = elm_scroller_add(layout);
	evas_object_show(scroller);

	elm_object_part_content_set(layout, "elm.swallow.content", scroller);

	/* Create Circle Scroller */
	circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);

	/* Set Scroller Policy */
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

	label = elm_label_add(scroller);
	elm_label_line_wrap_set(label, ELM_WRAP_MIXED);
	elm_object_text_set(label, "<br/><br/>This is setting application, "
								"By using the movement of the rotary, "
								"you can change the value of volume and brightness.<br/><br/><br/>");
	evas_object_show(label);

	elm_object_content_set(scroller, label);

	button = elm_button_add(layout);
	elm_object_style_set(button, "bottom");
	elm_object_text_set(button, "OK");
	elm_object_part_content_set(layout, "elm.swallow.button", button);
	evas_object_smart_callback_add(button, "clicked", _button_clicked_cb, ad);
	evas_object_show(button);

	nf_it = elm_naviframe_item_push(nf, _("Slider"), NULL, NULL, layout, "empty");
}



/*
 * @brief Function to get string on genlist title item's text part
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] part The name of text part
 * @param[out] char* A string with the characters to use as genlist title item's text part
 */
static char*
_gl_title_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];

	snprintf(buf, 1023, "%s", "Setting");

	return strdup(buf);
}

/*
 * @brief Function to get string on genlist item's text part
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] part The name of text part
 * @param[out] char* A string with the characters to use as genlist item's text part
 */
static char *
_gl_main_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];
	item_data *id = data;
	int index = id->index;

	if (!strcmp(part, "elm.text")) {
		snprintf(buf, 1023, "%s", main_menu_names[index]);
		return strdup(buf);
	}
	return NULL;
}

/*
 * @brief Function will be operated when genlist is deleted.
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 */
static void _gl_del(void *data, Evas_Object *obj)
{
	// FIXME: Unrealized callback can be called after this.
	// Accessing Item_Data can be dangerous on unrealized callback.
	item_data *id = data;
	if (id) free(id);
}

/*
 * @brief Function will be operated when naviframe pop its own item
 * @param[in] data The data to be passed to the callback function
 * @param[in] it The item to be popped from naviframe
 */
static Eina_Bool
_naviframe_pop_cb(void *data, Elm_Object_Item *it)
{
	ui_app_exit();
	return EINA_FALSE;
}

/*
 * @brief Function to create gui object
 * @param[in] ad The data structure to manage gui object
 */

static Evas_Object*
create_button_view(Evas_Object *parent)
{

	Evas_Object *btn, *box;
	char buf[64];

	box = elm_box_add(parent);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_padding_set(box, 0, 5 * elm_config_scale_get());
	evas_object_show(box);

	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", up_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "up");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(250), ELM_SCALE_SIZE(200));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);

	//down
	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", down_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "down");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(250), ELM_SCALE_SIZE(200));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);

	return box;
}

void
view_control_volume(void *data)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *scroller, *circle_scroller, *layout;
	Evas_Object *nf = ad->nf;
	Elm_Object_Item *nf_it;

	scroller = create_scroller(nf);
	layout = create_button_view(scroller);
	elm_object_content_set(scroller, layout);

	circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

	nf_it = elm_naviframe_item_push(nf, "Default Styles", NULL, NULL, scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);
}


void
view_PC_Setting(void *data)
{

	appdata_s *ad = (appdata_s *)data;
	Evas_Object *genlist = NULL;
	Evas_Object *naviframe = ad->nf;
	Elm_Object_Item *nf_it = NULL;
	Elm_Genlist_Item_Class *itc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *titc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *pitc = elm_genlist_item_class_new();
	item_data *id = NULL;
	int index = 0;

	/* Create Genlist */
	genlist = elm_genlist_add(naviframe);
	elm_genlist_mode_set(genlist, ELM_LIST_COMPRESS);
	evas_object_smart_callback_add(genlist, "selected", NULL, NULL);

	/* Create Circle Genlist */
	ad->circle_genlist = eext_circle_object_genlist_add(genlist, ad->circle_surface);

	/* Set Scroller Policy */
	eext_circle_object_genlist_scroller_policy_set(ad->circle_genlist, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(ad->circle_genlist, EINA_TRUE);

	/* Genlist Item Style */
	itc->item_style = "default";
	itc->func.text_get = _gl_main_text_get;
	itc->func.del = _gl_del;

	/* Genlist Title Item Style */
	titc->item_style = "title";
	titc->func.text_get = _gl_title_text_get;
	titc->func.del = _gl_del;

	/* Genlist Padding Item Style */
	pitc->item_style = "padding";

	/* Title Item Here */
	elm_genlist_item_append(genlist, titc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);

	/* Main Menu Items Here */

	 // PC CONTROL - > PCSETTING(밝기.배터리,볼륨,와이파이,블투,전원
//밝기
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);
	//배터리
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, _setting_brigteness_cb, ad);
	//볼륨
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, view_control_volume, ad);
//와이파이
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);
	//블투
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);
//전원
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);
	/* Padding Item Here */
	elm_genlist_item_append(genlist, pitc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);

	nf_it = elm_naviframe_item_push(naviframe, NULL, NULL, NULL, genlist, "empty");
	elm_naviframe_item_pop_cb_set(nf_it, _naviframe_pop_cb, ad->win);
}

