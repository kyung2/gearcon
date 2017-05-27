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
static Evas_Object*
create_scroller(Evas_Object *parent)
{
	Evas_Object *scroller = elm_scroller_add(parent);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	evas_object_show(scroller);

	return scroller;
}

static Evas_Object*
create_button_view(void *data)
{
	Evas_Object *btn;
	Evas_Object *popup;
	Evas_Object *layout;
	appdata_s *ad = (appdata_s *) data;

	popup = elm_popup_add(ad->win);
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

		//동글이



		//left
		btn = elm_button_add(popup);
		elm_object_style_set(btn, "popup/circle/left");
		elm_object_text_set(btn,"L");
		evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_object_part_content_set(popup, "button1", btn);
		evas_object_smart_callback_add(btn, "clicked", left_btn_clicked_cb, popup);

		//right
		btn = elm_button_add(popup);
		elm_object_style_set(btn, "popup/circle/right");
		elm_object_text_set(btn,"R");
		evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_object_part_content_set(popup, "button2", btn);
		evas_object_smart_callback_add(btn, "clicked", right_btn_clicked_cb, popup);
		evas_object_show(popup);



}

void
view_control_mouse(void *data)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *layout;
	Evas_Object *btn1,*btn2;
	Evas_Object *icon1, *icon2;
	Evas_Object *popup;

	popup = elm_popup_add(ad->win);
	elm_object_style_set(popup, "circle");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	layout = elm_layout_add(popup);
	elm_layout_theme_set(layout, "layout", "popup", "content/circle/buttons2");
//	elm_object_part_text_set(layout, "elm.text.title", "Popup title");

		//left
	btn1 = elm_button_add(popup);
		elm_object_style_set(btn1, "popup/circle/left");
		elm_object_text_set(btn1,"L");
		evas_object_size_hint_weight_set(btn1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_object_part_content_set(popup, "button1", btn1);
		evas_object_smart_callback_add(btn1, "clicked", left_btn_clicked_cb, NULL);

		//right
		btn2 = elm_button_add(popup);
		elm_object_style_set(btn2, "popup/circle/right");
		elm_object_text_set(btn2,"R");
		evas_object_size_hint_weight_set(btn2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_object_part_content_set(popup, "button2", btn2);
		evas_object_smart_callback_add(btn2, "clicked", right_btn_clicked_cb, NULL);
		evas_object_show(popup);

		elm_naviframe_item_push(ad->nf, "Popup", NULL, NULL, popup, "empty");
}




