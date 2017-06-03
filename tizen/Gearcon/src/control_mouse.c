
#include "gearcon.h"


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
	Evas_Object *popup = elm_popup_add(parent);
	elm_object_style_set(popup, "circle");
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, _popup_hide_cb, NULL);
    evas_object_smart_callback_add(popup, "dismissed", _popup_hide_finished_cb, NULL);

    evas_object_show(popup);
    return popup;
}


static Evas_Object*
create_button_view(Evas_Object *parent)
{
   Evas_Object *btn,*icon;
   Evas_Object *layout;

   layout = elm_layout_add(parent);
   elm_layout_theme_set(layout, "layout", "popup", "content/circle/buttons2");
   //elm_object_part_text_set(layout, "elm.text.title", "Popup title");

   elm_object_content_set(parent, layout);

   //left(no_
   	  btn = elm_button_add(parent);
      elm_object_style_set(btn, "popup/circle/left");
      evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
      elm_object_part_content_set(parent , "button1", btn);
      evas_object_smart_callback_add(btn, "clicked", right_btn_clicked_cb, parent);

      icon = elm_image_add(btn);
      elm_image_file_set(icon, ICON_DIR"/no.png", NULL);
      elm_object_part_content_set(btn, "elm.swallow.content", icon);
      evas_object_show(icon);

      //right
      btn = elm_button_add(parent);
      elm_object_style_set(btn, "popup/circle/right");
      evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
      elm_object_part_content_set(parent, "button2", btn);
      evas_object_smart_callback_add(btn, "clicked", left_btn_clicked_cb, parent);

      //icon
      /*
      icon = elm_image_add(btn);
      elm_image_file_set(icon, ICON_DIR"/yes.png", NULL);
      elm_object_part_content_set(btn, "elm.swallow.content", icon);
      evas_object_show(icon);
*/
      evas_object_show(layout);
      //path setting
      return layout;

}
void
view_control_mouse(void *data)
{
   appdata_s *ad = (appdata_s *)data;
   Evas_Object *layout;
   Evas_Object *popup;
   Evas_Object *nf = ad->nf;

   popup = create_popup(nf);
   layout = create_button_view(popup);

   evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
       evas_object_event_callback_add(popup, EVAS_CALLBACK_MOUSE_DOWN, m_mousedown_cb, ad);
       evas_object_event_callback_add(popup, EVAS_CALLBACK_MOUSE_UP, m_mouseup_cb, ad);
}



