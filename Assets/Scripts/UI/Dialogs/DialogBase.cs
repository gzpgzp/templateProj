using System;
using Manager;
using ResourceManger;
using UnityEngine;

namespace UI.Dialogs
{
    public class DialogBase<T> : MonoBehaviour where T : DialogContext
    {
        protected DialogContext dialogContext;
        protected Action closeAction;

        public virtual void Show()
        {
            var obj = ResourcesManager.Instance.LoadAndInstantiate($"{GamePath.DialogPath}/{name}");
            obj.transform.SetParent(DialogManager.Instance.transform);
        }

        public virtual void Show(DialogContext context)
        {
            var obj = ResourcesManager.Instance.LoadAndInstantiate($"{GamePath.DialogPath}/{name}");
            obj.transform.SetParent(DialogManager.Instance.transform);
            dialogContext = context;
        }

        public virtual void Close()
        {
            closeAction?.Invoke();
        }
    }
    
    /*public class DialogBase : MonoBehaviour
    {
        protected Action closeAction;

        public virtual void Show()
        {
            var obj = ResourcesManager.Instance.LoadAndInstantiate($"{GamePath.DialogPath}/{name}");
            obj.transform.SetParent(DialogManager.Instance.transform);
        }

        public virtual void Close()
        {
            closeAction?.Invoke();
        }
    }*/
}
