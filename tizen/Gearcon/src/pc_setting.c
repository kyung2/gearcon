#include "gearcon.h"
char temp_pcoff[25] = "";

#define NUM_OF_ITEMS 101
#define NUM_OF_GENLIST_DEMO_NAMES 101
#define NUM_OF_GENLIST_DEMO_LONG_TEXT 7

static void yes_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info);

typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;
char *icons_off[] =
{
ICON_DIR"/yes.png",
ICON_DIR"/no.png",
NULL

};
static void _popup_hide_cb(void *data, Evas_Object *obj, void *event_info)
{
	if (!obj)
		return;
	elm_popup_dismiss(obj);
}

static void _popup_hide_finished_cb(void *data, Evas_Object *obj,void *event_info)
{
	if (!obj)
		return;
	evas_object_del(obj);
}

// PC CONTROL - > PCSETTING(밝기.배터리,볼륨,와이파이,블투,전원
static char *main_menu_names[] =
{
/*** 1line styles ***/
		"밝기",
		"볼륨",
		"전원",
		/* do not delete below */
		NULL
};

void my_A_cb(void *data)
{
	appdata_s *ad = data;
	Evas_Object *bg;

	bg = elm_bg_add(ad->nf);
	elm_bg_color_set(bg, 66, 162, 206);
	elm_naviframe_item_push(ad->nf, "Solid Color", NULL, NULL, bg, "empty");

//a페이지 생성코드
}
*
_gl_title_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];
	snprintf(buf, 1023, "%s", "Setting");
	return strdup(buf);
}

static char *
_gl_main_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];
	item_data *id = data;
	int index = id->index;

	if (!strcmp(part, "elm.text"))
	{
		snprintf(buf, 1023, "%s", main_menu_names[index]);
		return strdup(buf);
	}
	return NULL;
}
static void _gl_del(void *data, Evas_Object *obj)
{
	// FIXME: Unrealized callback can be called after this.
	// Accessing Item_Data can be dangerous on unrealized callback.
	item_data *id = data;
	if (id)
		free(id);
}

static void yes_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "pc_종료  ");
	tul_send("pc|off", strlen("pc|off"));
}
static void no_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "PC 켜짐 ");
	elm_popup_dismiss(data);
}
static Evas_Object*
create_popup(Evas_Object *parent)
{
	Evas_Object *popup = elm_popup_add(parent);
	elm_object_style_set(popup, "circle");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, _popup_hide_cb,
			NULL);
	evas_object_smart_callback_add(popup, "dismissed", _popup_hide_finished_cb,
			NULL);

	evas_object_show(popup);
	return popup;
}
void view_PC_Setting(void *data)
{
	appdata_s *ad = (appdata_s *) data;
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
	ad->circle_genlist = eext_circle_object_genlist_add(genlist,
			ad->circle_surface);

	/* Set Scroller Policy */
	eext_circle_object_genlist_scroller_policy_set(ad->circle_genlist,
			ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

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
	elm_genlist_item_append(genlist, ttc, NULL, NULL, ELM_GENLIST_ITEM_NONE,
			NULL, ad);
	// PC CONTROL - > PCSETTING(밝기,볼륨,전원)

	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL,
			ELM_GENLIST_ITEM_NONE, view_control_brightness, ad);
	//볼륨
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL,
			ELM_GENLIST_ITEM_NONE, view_control_volume, ad);
	//전원
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL,
			ELM_GENLIST_ITEM_NONE, view_pcoff, ad);
	/* Padding Item Here */
	elm_genlist_item_append(genlist, pitc, NULL, NULL, ELM_GENLIST_ITEM_NONE,
			NULL, ad);

	nf_it = elm_naviframe_item_push(naviframe, NULL, NULL, NULL, genlist,
			"empty");
	eext_rotary_object_event_activated_set(genlist,EINA_TRUE);
	//eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);

}

static Evas_Object*
create_pcoff_view(Evas_Object *parent)
{
	Evas_Object *btn, *icon;
	Evas_Object *layout;

	layout = elm_layout_add(parent);
	elm_layout_theme_set(layout, "layout", "popup", "content/circle/buttons2");

	elm_object_part_text_set(layout, "elm.text", "PC OFF?");
	elm_object_content_set(parent, layout);

	//left(no_Bten)
	btn = elm_button_add(parent);
	elm_object_style_set(btn, "popup/circle/left");
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_part_content_set(parent, "button1", btn);
	evas_object_smart_callback_add(btn, "clicked", no_btn_clicked_cb, parent);

	icon = elm_image_add(btn);
	elm_image_file_set(icon, ICON_DIR"/no.png", NULL);
	elm_object_part_content_set(btn, "elm.swallow.content", icon);
	evas_object_show(icon);

	//right(yes_Btn)
	btn = elm_button_add(parent);
	elm_object_style_set(btn, "popup/circle/right");
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_part_content_set(parent, "button2", btn);
	evas_object_smart_callback_add(btn, "clicked", yes_btn_clicked_cb, parent);
	//icon
	icon = elm_image_add(btn);
	elm_image_file_set(icon, ICON_DIR"/yes.png", NULL);
	elm_object_part_content_set(btn, "elm.swallow.content", icon);
	evas_object_show(icon);

	evas_object_show(layout);
	return layout;
}
void view_pcoff(void *data)
{
	appdata_s *ad = (appdata_s *) data;
	Evas_Object *layout;
	Evas_Object *popup;

	Evas_Object *nf = ad->nf;
	//naviframe item
	popup = create_popup(nf);

	layout = create_pcoff_view(popup);
}

