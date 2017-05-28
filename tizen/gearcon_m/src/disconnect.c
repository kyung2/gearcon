/*
 *hyunkyung
 */
#include "gearcon_m.h"


typedef struct _item_data
{
   int index;
   Elm_Object_Item *item;
} item_data;
char *icons[] = {
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
static void
yes_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
   dlog_print(DLOG_DEBUG,LOG_TAG,"mouse_right ");
}

static void
no_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	//
   dlog_print(DLOG_DEBUG,LOG_TAG,"Disconncect: no_Dis");
}


static Evas_Object*
create_button_view(void *data)
{
   Evas_Object *btn,*icon;
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

   elm_object_part_text_set(layout, "elm.text", "연결꾾니");
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

return popup;

}

void
view_disconnect(void *data)
{
   appdata_s *ad = (appdata_s *)data;
   Evas_Object *popup;
   Evas_Object *nf = ad->nf;
   //naviframe item
   Elm_Object_Item *nf_it;

   popup = create_button_view(data);
   nf_it = elm_naviframe_item_push(nf, "Popup", NULL, NULL, popup, "empty");
   elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);

}



