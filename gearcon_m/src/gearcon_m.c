#include "gearcon_m.h"

static char *icon_path_list[] = {
	ICON_DIR"/music_controller_btn_mobile.png",
	ICON_DIR"/music_controller_btn_play.png",
	ICON_DIR"/music_controller_btn_repeat_all.png",
	ICON_DIR"/music_controller_btn_shuffle_on.png",
	NULL
};

static void _gl_selected_cb(void *user_data, Evas_Object *obj, void *event_info);
static void _item_selected_cb(void *data, Evas_Object *obj, void *event_info);
static void item_clicked_cb(void *data, Evas_Object *obj, void *event_info);
static Eina_Bool _naviframe_pop_cb(void *data, Elm_Object_Item *it);
static void create_rotary_selector(appdata_s *ad);
static void view_pc_setting(appdata_s *ad);
static Eina_Bool _rotary_handler_cb(void *data, Eext_Rotary_Event_Info *ev);



char *main_menu_names[] = {

	"PC Setting",
	"Mouse",
	"Keyboard",
	"PPT",
	"VIDEO",
	"PDF",
	"Connect",
	"Disconnect",
	"Setting",
	"Info",
	NULL

};

typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
_gl_selected_cb(void *user_data, Evas_Object *obj, void *event_info)
{
	Elm_Object_Item *it = (Elm_Object_Item *)event_info;
	elm_genlist_item_selected_set(it, EINA_FALSE);
}

static void
_item_selected_cb(void *data, Evas_Object *obj, void *event_info)
{
	Eext_Object_Item *item;
	const char *main_text;
	const char *sub_text;
	/* Get current seleted item object */
	item = eext_rotary_selector_selected_item_get(obj);

	/* Get set text for the item */
	main_text = eext_rotary_selector_item_part_text_get(item, "selector,main_text");
	sub_text = eext_rotary_selector_item_part_text_get(item, "selector,sub_text");
	dlog_print(DLOG_INFO, LOG_TAG, "hyunykung Select!!!!! !!! %s \n",sub_text);
	printf("Item Selected! Currently Selected %s, %s\n", main_text, sub_text);
}

static void
item_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	   appdata_s *ad = data;


	   /* Get current seleted item object */
	   Eext_Object_Item *item;
	   item = eext_rotary_selector_selected_item_get(obj);
	   const char *text = eext_rotary_selector_item_part_text_get(item,"selector,sub_text");
	   /* Get set text for the item */;
 //temp _ 배경 버튼 이벤트
//	   Evas_Object *bg;

	//   bg = elm_bg_add(ad->nf);
	  // elm_bg_color_set(bg, 66, 162, 206);
	   //e/lm_naviframe_item_push(ad->nf, "Solid Color", NULL, NULL, bg, "empty");

	   dlog_print(DLOG_INFO, LOG_TAG, "hyunykung ITEM name %s clicked \n" ,text);

	   if(!strncmp(text,"PC Setting",sizeof("PC Setting"))) {
		   my_A_cb(data);
	   }
	   else if(!strncmp(text,"Mouse",sizeof("Mouse"))) {
		   my_A_cb(data);
	   }
	   else {

	   }
	//   if (!strncmp(text,"PC Setting",sizeof("PC Setting"))) {
	//
	//   }


}


static Eina_Bool
_naviframe_pop_cb(void *data, Elm_Object_Item *it)
{
	ui_app_exit();
	return EINA_FALSE;
}
static Eina_Bool
_rotary_handler_cb(void *data, Eext_Rotary_Event_Info *ev)
{
	if(ev->direction == EEXT_ROTARY_DIRECTION_CLOCKWISE)
	{
		dlog_print(DLOG_DEBUG,LOG_TAG,"ROTARY HANDLER : Rotary device rotated in clockwise direction");
	}
	else
	{
		dlog_print(DLOG_DEBUG,LOG_TAG,"ROTARY HANDLER : Rotary device in counter clockwise direction");
	}
}

static void
create_rotary_selector(appdata_s *ad)
{
	Elm_Object_Item *nf_it = NULL;
	int idx = 0;

	//rotary selector = rs 라고 약어
	ad -> rs = eext_rotary_selector_add(ad->nf);
	eext_rotary_object_event_activated_set(ad->rs, EINA_TRUE);

	Eext_Object_Item * item;
	Evas_Object *image;
	for ( idx = 0; main_menu_names[idx];idx++) {
		item = eext_rotary_selector_item_append(ad->rs);
	/*
		image = elm_image_add(ad->rs);
		elm_image_file_set(image, "/images/music_controller_btn_mobile.png", NULL);
		eext_rotary_selector_item_part_content_set(item, "item,icon",
			                                              EEXT_ROTARY_SELECTOR_ITEM_STATE_NORMAL, image);

		*/
		eext_rotary_selector_item_part_text_set(item,"selector,main_text","GearCon");
		eext_rotary_selector_item_part_text_set(item,"selector,sub_text",main_menu_names[idx]);

	}

//	evas_object_smart_callback_add(ad->rs, "item,selected", _item_selected_cb, NULL);
	evas_object_smart_callback_add(ad->rs , "item,clicked", item_clicked_cb,ad);
	nf_it = elm_naviframe_item_push(ad->nf,NULL,NULL,NULL,ad->rs,"empty");
	elm_naviframe_item_pop_cb_set(nf_it, _naviframe_pop_cb, ad->win);
}

/*
 * @brief: Make genlist and circle_genlist for circular shape
 * @param[parent]: Naviframe to which you want to set the genlist
 */
Evas_Object *view_create_circle_genlist(Evas_Object *parent)
{
	Evas_Object *genlist = NULL;
	Evas_Object *circle_genlist = NULL;

	if (parent == NULL) {
		dlog_print(DLOG_ERROR, LOG_TAG, "parent is NULL.");
		return NULL;
	}


	genlist = elm_genlist_add(parent);
	/* this make selected list item is shown compressed */
	elm_genlist_mode_set(genlist, ELM_LIST_COMPRESS);
	evas_object_smart_callback_add(genlist, "selected", _gl_selected_cb, NULL);

	/* this make genlist style circular */
	circle_genlist = eext_circle_object_genlist_add(genlist, circle_genlist);
	eext_circle_object_genlist_scroller_policy_set(circle_genlist, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	eext_rotary_object_event_activated_set(circle_genlist, EINA_TRUE);

	//Register the rotary event handler
	eext_rotary_event_handler_add(_rotary_handler_cb,NULL);

	evas_object_show(genlist);

	return genlist;
}
//genlist로 이용하여 만드는거 그냥 한곳에 다 때려받을래 ^^



static void
create_base_gui(appdata_s *ad)
{

	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);

	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	//navifrmae
	ad->nf = elm_naviframe_add(ad->conform);
	eext_object_event_callback_add(ad->nf,EEXT_CALLBACK_BACK,eext_naviframe_back_cb,NULL);
	elm_object_content_set(ad->conform,ad->nf);

	create_rotary_selector(ad);
	/* Show window after base gui is set up */
	evas_object_show(ad->win);

}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
	   Initialize UI resources and application's data
	   If this function returns true, the main loop of application starts
	   If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

static void
layout_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void
app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max)
{
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(edj_path_out, edj_path_max, "%s%s", res_path, edj_file_in);
		free(res_path);
	}
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}
int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "ui_app_main() is failed. err = %d", ret);
	}

	return ret;
}
