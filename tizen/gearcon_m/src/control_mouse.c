/*
 *hyunkyung
 */
#include "gearcon_m.h"
/* Report line ends, timestamps, and momentum computed */


typedef struct _item_data
{
   int index;
   Elm_Object_Item *item;
} item_data;


static void
prev_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"prev button (pdf)");
}

static void
next_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"next button (pdf)");
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

void
view_control_mouse(void *data)
{
	appdata_s *ad = (appdata_s *)data;
		Evas_Object *scroller, *circle_scroller, *layout;
		Evas_Object *nf = ad->nf;
		Elm_Object_Item *nf_it;

		scroller = create_scroller(nf);
	//	layout = create_button_view(scroller);
		//elm_object_content_set(scroller, layout);

		evas_object_size_hint_weight_set(scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_event_callback_add(scroller, EVAS_CALLBACK_MOUSE_DOWN, m_mousedown_cb, ad);
		evas_object_event_callback_add(scroller, EVAS_CALLBACK_MOUSE_UP, m_mouseup_cb, ad);

		circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);
		eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
		eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

		nf_it = elm_naviframe_item_push(nf, "", NULL, NULL, scroller, NULL);
		elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);

}



