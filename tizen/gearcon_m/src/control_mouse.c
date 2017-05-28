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




/* Get or set the gesture layer long tap start timeout of an object */
void elm_gesture_layer_long_tap_start_timeout_set(Evas_Object *obj, double long_tap_start_timeout);
double elm_gesture_layer_long_tap_start_timeout_get(const Evas_Object *obj);

/* Get or set the gesture layer double tap timeout of an object */
void elm_gesture_layer_double_tap_timeout_set(Evas_Object *obj, double double_tap_timeout);
double elm_gesture_layer_double_tap_timeout_get(const Evas_Object *obj);

void elm_gesture_layer_tap_finger_size_set(Evas_Object *obj, Evas_Coord sz);
Evas_Coord elm_gesture_layer_tap_finger_size_get(const Evas_Object *obj);

/* Get or set the gesture layer line min length of an object */
void elm_gesture_layer_line_min_length_set(Evas_Object *obj, int line_min_length);
int elm_gesture_layer_line_min_length_get(const Evas_Object *obj);

/* Get or set the gesture layer line distance tolerance of an object */
void elm_gesture_layer_line_distance_tolerance_set(Evas_Object *obj, Evas_Coord line_distance_tolerance);
Evas_Coord elm_gesture_layer_line_distance_tolerance_get(const Evas_Object *obj);

void elm_gesture_layer_continues_enable_set(Evas_Object *obj, Eina_Bool continues_enable);
Eina_Bool elm_gesture_layer_continues_enable_get(const Evas_Object *obj);

/* Get or set the gesture layer line min length of an object */
void elm_gesture_layer_line_min_length_set(Evas_Object *obj, int line_min_length);
int elm_gesture_layer_line_min_length_get(const Evas_Object *obj);

void elm_gesture_layer_flick_time_limit_ms_set(Evas_Object *obj, unsigned int flick_time_limit_ms);
unsigned int elm_gesture_layer_flick_time_limit_ms_get(const Evas_Object *obj);




/* Start gesture callback */
static Evas_Event_Flags
n_finger_tap_start(void *data, void *event_info)
{
    Elm_Gesture_Taps_Info *p = (Elm_Gesture_Taps_Info *)event_info;
    printf("N tap started <%p> x,y=<%d,%d> count=<%d> timestamp=<%d> \n",
           event_info, p->x, p->y, p->n, p->timestamp);

    return EVAS_EVENT_FLAG_ON_HOLD;
}


static Evas_Event_Flags
n_finger_tap_abort(void *data, void *event_info)
{
    Elm_Gesture_Taps_Info *p = (Elm_Gesture_Taps_Info *)event_info;
    printf("N tap abort\n");

    return EVAS_EVENT_FLAG_ON_HOLD;
}

static Evas_Event_Flags
momentum_start(void *data, void *event_info)
{
    Elm_Gesture_Momentum_Info *p = (Elm_Gesture_Momentum_Info *)event_info;
    printf("momentum started x1,y1=<%d,%d> tx,ty=<%u,%u> n=<%u>\n",
           p->x1, p->y1, p->tx, p->ty, p->n);

    return EVAS_EVENT_FLAG_ON_HOLD;
}
static Evas_Event_Flags
momentum_move(void *data, void *event_info)
{
    Elm_Gesture_Momentum_Info *p = (Elm_Gesture_Momentum_Info *)event_info;
    printf("momentum move x1,y1=<%d,%d> x2,y2=<%d,%d> tx,ty=<%u,%u> mx=<%d> my=<%d> n=<%u>\n",
           p->x1, p->y1, p->x2, p->y2, p->tx, p->ty, p->mx, p->my, p->n);

    return EVAS_EVENT_FLAG_ON_HOLD;
}

static Evas_Event_Flags
momentum_end(void *data, void *event_info)
{
    Elm_Gesture_Momentum_Info *p = (Elm_Gesture_Momentum_Info *)event_info;
    printf("momentum ended x1,y1=<%d,%d> x2,y2=<%d,%d> tx,ty=<%u,%u> mx=<%d> my=<%d> n=>%u>\n",
           p->x1, p->y1, p->x2, p->y2, p->tx, p->ty, p->mx, p->my, p->n);

    return EVAS_EVENT_FLAG_ON_HOLD;
}

static Evas_Event_Flags
momentum_abort(void *data, void *event_info)
{
    printf("momentum abort\n");

    return EVAS_EVENT_FLAG_ON_HOLD;
}

static Evas_Event_Flags
flick_start(void *data, void *event_info)
{
    Elm_Gesture_Line_Info *p = (Elm_Gesture_Line_Info *)event_info;
    printf("line started angle=<%lf> x1,y1=<%d,%d> x2,y2=<%d,%d> tx,ty=<%u,%u> n=<%u>\n",
           p->angle, p->momentum.x1, p->momentum.y1, p->momentum.x2, p->momentum.y2,
           p->momentum.tx, p->momentum.ty, p->momentum.n);

    return EVAS_EVENT_FLAG_ON_HOLD;
}

flick_move(void *data, void *event_info)
{
    Elm_Gesture_Line_Info *p = (Elm_Gesture_Line_Info *)event_info;
    printf("line move angle=<%lf> x1,y1=<%d,%d> x2,y2=<%d,%d> tx,ty=<%u,%u> n=<%u>\n",
           p->angle, p->momentum.x1, p->momentum.y1, p->momentum.x2, p->momentum.y2,
           p->momentum.tx, p->momentum.ty, p->momentum.n);

    return EVAS_EVENT_FLAG_ON_HOLD;
}


flick_end(void *data, void *event_info)
{
    Elm_Gesture_Line_Info *p = (Elm_Gesture_Line_Info *)event_info;
    printf("line end angle=<%lf> x1,y1=<%d,%d> x2,y2=<%d,%d> tx,ty=<%u,%u> n=<%u>,\n",
           p->angle, p->momentum.x1, p->momentum.y1, p->momentum.x2, p->momentum.y2,
           p->momentum.tx, p->momentum.ty, p->momentum.n);

    return EVAS_EVENT_FLAG_ON_HOLD;
}

static Evas_Event_Flags
flick_abort(void *data, void *event_info)
{
    Elm_Gesture_Line_Info *p = (Elm_Gesture_Line_Info *)event_info;
    printf("line abort\n");

    return EVAS_EVENT_FLAG_ON_HOLD;
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

      //right
      btn = elm_button_add(popup);
      elm_object_style_set(btn, "popup/circle/right");
      elm_object_text_set(btn,"R");
      evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
      elm_object_part_content_set(popup, "button2", btn);
      evas_object_show(popup);



}
static Evas_Event_Flags
n_finger_tap_end(void *data, void *event_info)
{
   appdata_s *ad = data;
   Elm_Gesture_Taps_Info *p = (Elm_Gesture_Taps_Info *) event_info;
   return EVAS_EVENT_FLAG_ON_HOLD;
}
void
view_control_mouse(void *data)
{
   appdata_s *ad = (appdata_s *) data;
   Evas_Object *win;
   Evas_Object *r; /* Gesture layer transparent object */
   Evas_Object *g; /* Gesture layer object */
   Elm_Object_Item *nf_it, *tabbar_it;
   Evas_Object *box, *rect;


   box= elm_box_add(ad->nf);
   evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   elm_box_padding_set(box, 0, 5 * elm_config_scale_get());
   evas_object_show(box);

     rect = evas_object_rectangle_add(evas_object_evas_get(box));
     evas_object_size_hint_weight_set(rect, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
     evas_object_size_hint_align_set(rect, EVAS_HINT_FILL, EVAS_HINT_FILL);
     evas_object_color_set(rect, 204, 204, 204, 255);
     evas_object_repeat_events_set(rect, EINA_TRUE);



      g = elm_gesture_layer_add(win);
      elm_gesture_layer_attach(g, rect);
      elm_box_pack_end(box,rect);
      evas_object_show(rect);



}



