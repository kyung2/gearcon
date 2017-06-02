#include "gearcon_m.h"


#define NUM_OF_ITEMS 101
#define NUM_OF_GENLIST_DEMO_NAMES 101
#define NUM_OF_GENLIST_DEMO_LONG_TEXT 7

//함수 여기다가 선언좀 해놓기!

static Evas_Object* create_scroller(Evas_Object *parent);
static Eina_Bool _setting_finished_cb(void *data, Elm_Object_Item *it);
static void yes_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info);
static void no_btn_clicekd_cb(void *data, Evas_Object *obj , void *event_info);

typedef struct _item_data {
	int index;
	Elm_Object_Item *item;
} item_data;
char *icons_off[] = {
		ICON_DIR"/yes.png",
		ICON_DIR"/no.png",
		NULL

};
static void
_popup_hide_cb(void *data, Evas_Object *obj, void *event_info)
{
   if(!obj) return;
   elm_popup_dismiss(obj);
}

static void
_popup_hide_finished_cb(void *data, Evas_Object *obj, void *event_info)
{
   if(!obj) return;
   evas_object_del(obj);
}

	 // PC CONTROL - > PCSETTING(밝기.배터리,볼륨,와이파이,블투,전원
static char *main_menu_names[] = {
	/*** 1line styles ***/
	"밝기",
	"볼륨",
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


static void
gl_selected_cb(void *data, Evas_Object *obj, void *event_info)
{
	Elm_Object_Item *it = (Elm_Object_Item *)event_info;
	elm_genlist_item_selected_set(it, EINA_FALSE);
}

/*
 * @brief Function to get string on genlist item's text part
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] part The name of text part
 * @param[out] char* A string with the characters to use as genlist item's text part
 */

static char*
_gl_title_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];
//test
	snprintf(buf, 1023, "%s", "Setting");
	return strdup(buf);
}

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

static void
yes_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
   dlog_print(DLOG_DEBUG,LOG_TAG,"pc_종료  ");
}
static void
no_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
   dlog_print(DLOG_DEBUG,LOG_TAG,"PC 켜짐 ");
}


void
view_PC_Setting(void *data)
{

	appdata_s *ad = (appdata_s *)data;
	Evas_Object *genlist = NULL;
	Evas_Object *naviframe = ad->nf;
	Elm_Object_Item *nf_it = NULL;
	Elm_Genlist_Item_Class *itc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *ttc = elm_genlist_item_class_new();
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


	/* Genlist Title Item Style */
	ttc->item_style = "title";
	ttc->func.text_get = _gl_title_text_get;
	ttc->func.del = _gl_del;

	/* Genlist Item Style */
	itc->item_style = "default";
	itc->func.text_get = _gl_main_text_get;
	itc->func.del = _gl_del;

	/* Genlist Padding Item Style */
	pitc->item_style = "padding";

	/* Main Menu Items Here */
	elm_genlist_item_append(genlist,ttc,NULL,NULL,ELM_GENLIST_ITEM_NONE,NULL,ad);
	 // PC CONTROL - > PCSETTING(밝기,볼륨,전원)


	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, view_control_brightness, ad);
	//볼륨
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, view_control_volume, ad);
	//전원
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, view_pcoff, ad);
	/* Padding Item Here */
	elm_genlist_item_append(genlist, pitc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);


	nf_it = elm_naviframe_item_push(naviframe, NULL, NULL, NULL, genlist, "empty");


	//	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);

}

void
view_pcoff(void *data)
{
	   Evas_Object *btn,*icon;
	   Evas_Object *popup;
	   Evas_Object *layout;
	   appdata_s *ad = (appdata_s *)data;
	   Evas_Object *nf = ad->nf;
   //naviframe item
	   Elm_Object_Item *nf_it;

   popup = elm_popup_add(nf);
   elm_object_style_set(popup, "circle");
   evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, _popup_hide_cb, NULL);
   evas_object_smart_callback_add(popup, "dismissed", _popup_hide_finished_cb, NULL);

   layout = elm_layout_add(popup);
   elm_layout_theme_set(layout, "layout", "popup", "content/circle/buttons2");
   //elm_object_part_text_set(layout, "elm.text.title", "Popup title");

   elm_object_part_text_set(layout, "elm.text", "전원종료");
   elm_object_content_set(popup, layout);

   //left(no_
   	  btn = elm_button_add(popup);
      elm_object_style_set(btn, "popup/circle/left");
      evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
      elm_object_part_content_set(popup, "button1", btn);
      evas_object_smart_callback_add(btn, "clicked", no_btn_clicked_cb, popup);

      icon = elm_image_add(btn);
      elm_image_file_set(icon, ICON_DIR"/no.png", NULL);
      elm_object_part_content_set(btn, "elm.swallow.content", icon);
      evas_object_show(icon);


      //right
      btn = elm_button_add(popup);
      elm_object_style_set(btn, "popup/circle/right");
      evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
      elm_object_part_content_set(popup, "button2", btn);
      evas_object_smart_callback_add(btn, "clicked", yes_btn_clicked_cb, popup);

      //icon
      icon = elm_image_add(btn);
      elm_image_file_set(icon, ICON_DIR"/yes.png", NULL);
      elm_object_part_content_set(btn, "elm.swallow.content", icon);
      evas_object_show(icon);

      evas_object_show(popup);

}




