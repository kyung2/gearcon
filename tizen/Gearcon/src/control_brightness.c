/*
 *hyunkyung
 */
#include "gearcon.h"


typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;

Eina_Bool
_rotary_handler_brightness_cb(void *data, Eext_Rotary_Event_Info *ev)
{
	dlog_print(DLOG_DEBUG ,LOG_TAG,"direction %d",ev->direction);
   if (ev->direction == EEXT_ROTARY_DIRECTION_CLOCKWISE)
   {
      dlog_print(DLOG_DEBUG, LOG_TAG, "hello~~ 돌아간다 ~");
   }
   else
   {
      dlog_print(DLOG_DEBUG, LOG_TAG, "반시계반향~ ");
   }

   return EINA_FALSE;
}
static void
up_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"밝아져라 ");
}
static void
down_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG,LOG_TAG,"어두워져라 ");
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
	elm_box_padding_set(box, 0, 10 * elm_config_scale_get());
	evas_object_show(box);

	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", up_btn_clicked_cb,NULL);
	elm_object_text_set(btn, "<align=center><font_size=20><aligh<br>brightness</br><b>UP</b></font></align>");
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(100), ELM_SCALE_SIZE(100));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);
	//down
	btn = elm_button_add(box);
	evas_object_smart_callback_add(btn, "clicked", down_btn_clicked_cb,NULL);
	elm_object_text_set(btn, "<font_size=20><aligh<br>brightness</br><b>DOWN</b></font>");
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(100), ELM_SCALE_SIZE(100));
	evas_object_show(btn);
	elm_box_pack_end(box, btn);

	return box;
}

void
view_control_brightness(void *data)
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
	eext_rotary_object_event_callback_add(scroller,_rotary_handler_brightness_cb,NULL);
	eext_rotary_object_event_activated_set(scroller, EINA_FALSE);

	nf_it = elm_naviframe_item_push(nf, "", NULL, NULL, scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);

}




