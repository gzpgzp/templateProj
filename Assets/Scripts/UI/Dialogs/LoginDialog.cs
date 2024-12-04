using DG.Tweening;
using Manager;
using ResourceManger;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Dialogs
{
    public class LoginDialog : MonoBehaviour
    {
        [SerializeField] private Button loginBtn;

        private void OnEnable()
        {
            loginBtn.transform.DOScale(1.2f, 0.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
            
            loginBtn.onClick.AddListener(() =>
            {
                AudioManager.Instance.PlayButtonClickSound();
                MySceneManager.Instance.LoadScene(GameScene.battle, () =>
                {
                    Destroy(gameObject);
                });
            });
        }

        private void Close()
        {
            Destroy(gameObject);
        }
    }
}
