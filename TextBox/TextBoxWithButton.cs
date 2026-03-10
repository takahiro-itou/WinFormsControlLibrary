
using System;
using System.ComponentModel;

namespace  WinFormsControl  {

public partial class TextBoxWithButton : UserControl
{
    public TextBoxWithButton()
    {
        InitializeComponent();
    }

    //----------------------------------------------------------------
    /**   ButtonText  プロパティ
    **
    **/
    [Browsable(true)
      , Description("ボタンに表示する文字列")
      , Category("表示")
    ]
    public System.String ButtonText
    {
        get { return  btnRefer.Text; }
        set { btnRefer.Text = value; }
    }

    //----------------------------------------------------------------
    /**   LabelCaption  プロパティ
    **
    **/
    [Browsable(true)
      , Description("ラベルに表示する文字列")
      , Category("表示")
    ]
    public System.String LabelCaption
    {
        get { return  lblCaption.Text; }
        set { lblCaption.Text = value; }
    }

    //----------------------------------------------------------------
    /**   Text  プロパティ
    **
    **/
    [Browsable(true)
      , Description("テキストボックスに入力された文字列")
      , Category("表示")
    ]
    public new System.String Text
    {
        get { return  txtEdit.Text; }
        set { txtEdit.Text = value; }
    }

    //----------------------------------------------------------------
    /**   ButtonClick イベント
    **
    **/
    [Browsable(true)
      , Description("ボタンがクリックされた時に発生します")
      , Category("アクション")
    ]
    public event System.EventHandler<EventArgs>? ButtonClick;

    //----------------------------------------------------------------
    /**   イベントハンドラを呼び出すメソッド
    **
    **/
    protected virtual void OnReferButtonClick(EventArgs e)
    {
        var eventHandler = ButtonClick;
        if ( eventHandler != null ) {
            eventHandler(this, e);
        }
    }

    //----------------------------------------------------------------
    /**   イベントハンドラ
    **
    **    ボタンのクリックイベント
    **/
    private void btnRefer_Click(object sender, EventArgs e)
    {
        OnReferButtonClick(e);
    }

}   //  End of partial class  TextBoxWithButton

}   //  End of namespace  WinFormsControl
