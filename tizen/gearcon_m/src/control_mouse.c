/*
 *hyunkyung
 */
#include "gearcon_m.h"


typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;

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
static void
right_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"mouse_right ");
}

static void
left_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"mouse_left");
}

void
view_control_mouse(void *data)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *layout;
	Evas_Object *btn;
	Evas_Object *popup;
	Evas_Object *scroller, *circle_scroller;
	Evas_Object *nf = ad->nf;
	Elm_Object_Item *nf_it;

	popup = elm_popup_add(nf);
	elm_object_style_set(popup, "circle");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, _popup_hide_cb, NULL);
	evas_object_smart_callback_add(popup, "dismissed", _popup_hide_finished_cb, NULL);

	layout = elm_layout_add(popup);
	elm_layout_theme_set(layout, "layout", "popup", "content/circle/buttons2");
	//elm_object_part_text_set(layout, "elm.text.title", "Popup title");

	elm_object_part_text_set(layout, "elm.text", "This is scrollable popup text."
		"This part is made by adding long text in popup. Popup internally added "
		"scroller to this layout when size of text is greater than total popup "
			"height. This has two buttons in action area and title text in title area");
		elm_object_content_set(popup, layout);


		//right
		btn = elm_button_add(popup);
		elm_object_style_set(btn, "popup/circle/right");
		elm_object_text_set(btn,"R");
		evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_object_part_content_set(popup, "button1", btn);
		evas_object_smart_callback_add(btn, "clicked", right_btn_clicked_cb, popup);


		//left
		btn = elm_button_add(popup);
		elm_object_style_set(btn, "popup/circle/left");
		elm_object_text_set(btn,"L");
		evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_object_part_content_set(popup, "button2", btn);
		evas_object_smart_callback_add(btn, "clicked", left_btn_clicked_cb, popup);

	evas_object_show(popup);

	circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

	nf_it = elm_naviframe_item_push(nf, "", NULL, NULL, scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);

}




