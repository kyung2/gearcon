/*
 *hyunkyung
 */
#include "gearcon.h"
/* Report line ends, timestamps, and momentum computed */


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

static void
m_mousedown_cb(void *data, Evas *evas, Evas_Object *obj, void *event_info){
   appdata_s *ad = data;
   dlog_print(DLOG_DEBUG,LOG_TAG,"down?");
   Evas_Event_Mouse_Down *ev =event_info;
   Evas_Coord x = ev->canvas.x;
   Evas_Coord y = ev->canvas.y;
   ad->ex_point = ev->canvas;
   dlog_print(DLOG_DEBUG,LOG_TAG,"Mouse down, %d, %d", x, y);
}
static void
m_mouseup_cb(void *data, Evas *evas, Evas_Object *obj, void *event_info){

   appdata_s *ad = data;
   dlog_print(DLOG_DEBUG,LOG_TAG,"up?");
   Evas_Event_Mouse_Down *ev =event_info;
   Evas_Coord x = ev->canvas.x;
   Evas_Coord y = ev->canvas.y;
   dlog_print(DLOG_DEBUG,LOG_TAG,"Mouse up, %d, %d", x, y);
   dlog_print(DLOG_DEBUG,LOG_TAG,"Mouse moved, %d, %d", x-ad->ex_point.x, y- ad->ex_point.y);
}
static Evas_Object*
create_popup(Evas_Object *parent)
{
	Evas_Object *popup;
	/* (win - conformant - naviframe) */
	// Add an button to popup
	popup = elm_popup_add(parent);
	elm_object_style_set(popup,"circle");
	evas_object_size_hint_weight_set(popup,EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, _popup_hide_cb, NULL);
	evas_object_smart_callback_add(popup, "dismissed", _popup_hide_finished_cb, NULL);
	evas_object_show(popup);

	return popup;
}
static Evas_Object*
create_mouse_button_view(Evas_Object *parent) {
	Evas_Object *layout;

	Evas_Object *left_btn,*right_btn;
	layout = elm_layout_add(parent);

//add left btn

	left_btn = elm_button_add(layout);
	elm_object_style_set(left_btn,"layout");
	elm_object_text_set(left_btn,"좌");
	elm_object_part_content_set(layout,"left_btn",left_btn);


	//add right btn
	right_btn = elm_button_add(layout);
	elm_object_style_set(right_btn,"layout");
	elm_object_text_set(right_btn,"우");

	/* Set the buttons to the action area */
	elm_object_part_content_set(layout, "left_btn", left_btn);
	elm_object_part_content_set(layout, "right_btn", right_btn);

	// add a callback function to popup

	return layout;

}
/*
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
	evas_object_smart_callback_add(btn, "clicked", prev_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "prev");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(100), ELM_SCALE_SIZE(100));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);

	//down
	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", next_btn_clicked_cb,NULL);
	snprintf(buf, sizeof(buf), "next");
	elm_object_text_set(btn, buf);
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(100), ELM_SCALE_SIZE(100));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);

	return box;

}
*/
void
view_control_mouse(void *data)
{
	appdata_s *ad = (appdata_s *)data;
		Evas_Object *popup,*layout;
		Evas_Object *nf = ad->nf;
		Elm_Object_Item *nf_it;

		popup = create_popup(nf);
		layout = create_mouse_button_view(popup);

		evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_event_callback_add(popup, EVAS_CALLBACK_MOUSE_DOWN, m_mousedown_cb, ad);
		evas_object_event_callback_add(popup, EVAS_CALLBACK_MOUSE_UP, m_mouseup_cb, ad);

		nf_it = elm_naviframe_item_push(nf, "", NULL, NULL, popup, NULL);
		elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);

}
