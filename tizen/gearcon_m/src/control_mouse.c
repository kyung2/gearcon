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

struct Elm_Gesture_Flick_Info {
    Elm_Gesture_Momentum_Info momentum; /* Line momentum info */
    double angle; /* Angle (direction) of the lines */
};





/* Get or set the gesture layer long tap start timeout of an object */
void elm_gesture_layer_long_tap_start_timeout_set(Evas_Object *obj, double long_tap_start_timeout);
double elm_gesture_layer_long_tap_start_timeout_get(const Evas_Object *obj);

/* Get or set the gesture layer double tap timeout of an object */
void elm_gesture_layer_double_tap_timeout_set(Evas_Object *obj, double double_tap_timeout);
double elm_gesture_layer_double_tap_timeout_get(const Evas_Object *obj);


/* Get or set the gesture layer finger size for taps */
void elm_gesture_layer_tap_finger_size_set(Evas_Object *obj, Evas_Coord sz);
Evas_Coord elm_gesture_layer_tap_finger_size_get(const Evas_Object *obj);

/* Get or set the gesture layer flick time limit (in milliseconds) of an object */
void elm_gesture_layer_flick_time_limit_ms_set(Evas_Object *obj, unsigned int flick_time_limit_ms);
unsigned int elm_gesture_layer_flick_time_limit_ms_get(const Evas_Object *obj);

/* Get or set the gesture layer continue mode of an object */
void elm_gesture_layer_continues_enable_set(Evas_Object *obj, Eina_Bool continues_enable);
Eina_Bool elm_gesture_layer_continues_enable_get(const Evas_Object *obj);



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
n_finger_tap_end(void *data, void *event_info)
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
flick_start(void *data, void *event_info)
{
	struct Elm_Gesture_Flick_Info *p = (struct Elm_Gesture_Flick_Info *)event_info;
    printf("line started angle=<%lf> x1,y1=<%d,%d> x2,y2=<%d,%d> tx,ty=<%u,%u> n=<%u>\n",
           p->angle, p->momentum.x1, p->momentum.y1, p->momentum.x2, p->momentum.y2,
           p->momentum.tx, p->momentum.ty, p->momentum.n);

    return EVAS_EVENT_FLAG_ON_HOLD;
}

static Evas_Event_Flags
flick_end(void *data, void *event_info)
{
	struct Elm_Gesture_Flick_Info *p = (struct Elm_Gesture_Flick_Info *)event_info;
    printf("line end angle=<%lf> x1,y1=<%d,%d> x2,y2=<%d,%d> tx,ty=<%u,%u> n=<%u>,\n",
           p->angle, p->momentum.x1, p->momentum.y1, p->momentum.x2, p->momentum.y2,
           p->momentum.tx, p->momentum.ty, p->momentum.n);

    return EVAS_EVENT_FLAG_ON_HOLD;
}
static Evas_Event_Flags
flick_abort(void *data, void *event_info)
{
	struct Elm_Gesture_Flick_Info *p = (struct Elm_Gesture_Flick_Info *)event_info;
    printf("line abort\n");

    return EVAS_EVENT_FLAG_ON_HOLD;
}
static Evas_Object *
create_gesture_layer(appdata_s *ad)
{
   Evas_Object *g = elm_gesture_layer_add(ad->win);
   elm_gesture_layer_attach(g, ad->rect);
}

static Evas_Object*
create_touch_view(Evas_Object *parent)
{
	appdata_s *ad = (appdata_s *) data;
	Evas_Object *box = ad->box;
	Evas_Object *rect =ad->rect;

	box = elm_box_add(parent);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_padding_set(box, 0, 5 * elm_config_scale_get());
	evas_object_show(box);


	 // Event Rect
	   rect = evas_object_rectangle_add(evas_object_evas_get(box));99
	   evas_object_size_hint_weight_set(rect, EVAS_HINT_EXPAND, VAS_HINT_EXPAND);
	   evas_object_size_hint_align_set(rect, EVAS_HINT_FILL, EVAS_HINT_FILL);
	   evas_object_color_set(rect, 204, 204, 204, 255);
	   evas_object_repeat_events_set(rect, EINA_TRUE);

	   ad->g =create_gesture_layer(ad);

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
   appdata_s *ad = (appdata_s *) data;
   Evas_Object *nf = ad->nf;
   Evas_Object *win = ad->win;
   //rect
   Evas_Object *r; /* Gesture layer transparent object */
   Evas_Object *g; /* Gesture layer object */

   awin = elm_win_util_standard_add("gesture_layer", "Gesture Layer");
   elm_win_autodel_set(win, EINA_TRUE);

   /* Gesture layer transparent object */
   r = evas_object_rectangle_add(evas_object_evas_get(win));
   evas_object_move(r, 0, 0);
   evas_object_color_set(r, 0, 0, 0, 0);
   elm_win_resize_object_add(win, r);


   /* Gesture layer object */
   g = elm_gesture_layer_add(win);
   elm_gesture_layer_attach(g, r);
   evas_object_show(r);


	nf_it = elm_naviframe_item_push(nf, "", NULL, NULL, scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);



}



