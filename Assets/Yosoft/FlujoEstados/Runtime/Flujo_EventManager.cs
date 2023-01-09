using UnityEngine;

namespace FlujoEstados.Runtime
{
    public enum Compute_DistanceTransform_EventTypes { Processing, Completed };
    public static class Flujo_EventManager
    {
        public static readonly FlujoFastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT = new FlujoFastAction<object, Compute_DT_EventArgs>();

        // Event & Delegate used to notify TextMesh Pro objects that Material properties have been changed.
        public static readonly FlujoFastAction<bool, Material> MATERIAL_PROPERTY_EVENT = new FlujoFastAction<bool, Material>();

        public static readonly FlujoFastAction<bool, Object> FONT_PROPERTY_EVENT = new FlujoFastAction<bool, Object>();

        public static readonly FlujoFastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT = new FlujoFastAction<bool, Object>();

        public static readonly FlujoFastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT = new FlujoFastAction<bool, Object>();

        public static readonly FlujoFastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT = new FlujoFastAction<GameObject, Material, Material>();

        public static readonly FlujoFastAction<bool> TEXT_STYLE_PROPERTY_EVENT = new FlujoFastAction<bool>();

        public static readonly FlujoFastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT = new FlujoFastAction<Object>();

        public static readonly FlujoFastAction TMP_SETTINGS_PROPERTY_EVENT = new FlujoFastAction();

        public static readonly FlujoFastAction RESOURCE_LOAD_EVENT = new FlujoFastAction();

        public static readonly FlujoFastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT = new FlujoFastAction<bool, Object>();

        public static readonly FlujoFastAction<Object> TEXT_CHANGED_EVENT = new FlujoFastAction<Object>();

        //public static readonly FlujoFastAction WILL_RENDER_CANVASES = new FlujoFastAction();

        public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat)
        {
            MATERIAL_PROPERTY_EVENT.Call(isChanged, mat);
        }

        public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, Object obj)
        {
            FONT_PROPERTY_EVENT.Call(isChanged, obj);
        }

        public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj)
        {
            SPRITE_ASSET_PROPERTY_EVENT.Call(isChanged, obj);
        }

        public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, Object obj)
        {
            TEXTMESHPRO_PROPERTY_EVENT.Call(isChanged, obj);
        }

        public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial)
        {
            DRAG_AND_DROP_MATERIAL_EVENT.Call(sender, currentMaterial, newMaterial);
        }

        public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged)
        {
            TEXT_STYLE_PROPERTY_EVENT.Call(isChanged);
        }

        public static void ON_CONDICION_PROPERTY_CHANGED(Object obj)
        {
            COLOR_GRADIENT_PROPERTY_EVENT.Call(obj);
        }


        public static void ON_TEXT_CHANGED(Object obj)
        {
            TEXT_CHANGED_EVENT.Call(obj);
        }

        public static void ON_TMP_SETTINGS_CHANGED()
        {
            TMP_SETTINGS_PROPERTY_EVENT.Call();
        }

        public static void ON_RESOURCES_LOADED()
        {
            RESOURCE_LOAD_EVENT.Call();
        }

        public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, Object obj)
        {
            TEXTMESHPRO_UGUI_PROPERTY_EVENT.Call(isChanged, obj);
        }

        //public static void ON_BASE_MATERIAL_CHANGED(Material mat)
        //{
        //    BASE_MATERIAL_EVENT.Call(mat);
        //}

        //public static void ON_PROGRESSBAR_UPDATE(Progress_Bar_EventTypes event_type, Progress_Bar_EventArgs eventArgs)
        //{
        //    if (PROGRESS_BAR_EVENT != null)
        //        PROGRESS_BAR_EVENT(event_type, eventArgs);
        //}

        public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e)
        {
            COMPUTE_DT_EVENT.Call(Sender, e);
        }
    }
    public class Compute_DT_EventArgs
    {
        public Compute_DistanceTransform_EventTypes EventType;
        public float ProgressPercentage;
        public Color[] Colors;


        public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress)
        {
            EventType = type;
            ProgressPercentage = progress;
        }

        public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Color[] colors)
        {
            EventType = type;
            Colors = colors;
        }

    }
}