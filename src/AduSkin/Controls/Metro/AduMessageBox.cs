using AduSkin.Themes.Metro;
using System.Windows;

namespace AduSkin.Controls.Metro
{
   public static class AduMessageBox
   {
      /// <summary>
      /// Displays a message box that has a message and returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult Show(string messageBoxText)
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText);
         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message and a title bar caption; and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult Show(string messageBoxText, string caption = "提示")
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption);
         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box in front of the specified window. The message box displays a message and returns a result.
      /// </summary>
      /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult Show(Window owner, string messageBoxText)
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText);
         msg.Owner = owner;
         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box in front of the specified window. The message box displays a message and title bar caption; and it returns a result.
      /// </summary>
      /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult Show(Window owner, string messageBoxText, string caption = "提示")
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption);
         msg.Owner = owner;
         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message, title bar caption, and button; and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <param name="button">A System.Windows.MessageBoxButton value that specifies which button or buttons to display.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult Show(string messageBoxText, string caption = "提示", MessageBoxButton button = MessageBoxButton.OK)
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption, button);
         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message, title bar caption, button, and icon; and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <param name="button">A System.Windows.MessageBoxButton value that specifies which button or buttons to display.</param>
      /// <param name="icon">A System.Windows.MessageBoxImage value that specifies the icon to display.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult Show(string messageBoxText, string caption = "提示",
         MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.Information)
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption, button, icon);
         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message, title bar caption, and OK button with a custom System.String value for the button's text; and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <param name="okButtonText">A System.String that specifies the text to display within the OK button.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult ShowOK(string messageBoxText, string caption = "提示",
         string okButtonText = "好的")
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption, MessageBoxButton.OK);
         msg.OkButtonText = okButtonText;

         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message, title bar caption, OK button with a custom System.String value for the button's text, and icon; and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <param name="okButtonText">A System.String that specifies the text to display within the OK button.</param>
      /// <param name="icon">A System.Windows.MessageBoxImage value that specifies the icon to display.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult ShowOK(string messageBoxText, string caption = "提示",
         string okButtonText = "好的", MessageBoxImage icon = MessageBoxImage.Information)
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption, MessageBoxButton.OK, icon);
         msg.OkButtonText = okButtonText;

         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message, caption, and OK/Cancel buttons with custom System.String values for the buttons' text;
      /// and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <param name="okButtonText">A System.String that specifies the text to display within the OK button.</param>
      /// <param name="cancelButtonText">A System.String that specifies the text to display within the Cancel button.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult ShowOKCancel(string messageBoxText, string caption = "提示",
         string okButtonText = "好的", string cancelButtonText = "取消")
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption, MessageBoxButton.OKCancel);
         msg.OkButtonText = okButtonText;
         msg.CancelButtonText = cancelButtonText;

         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message, caption, OK/Cancel buttons with custom System.String values for the buttons' text, and icon;
      /// and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <param name="okButtonText">A System.String that specifies the text to display within the OK button.</param>
      /// <param name="cancelButtonText">A System.String that specifies the text to display within the Cancel button.</param>
      /// <param name="icon">A System.Windows.MessageBoxImage value that specifies the icon to display.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult ShowOKCancel(string messageBoxText, string caption = "提示",
         string okButtonText = "好的", string cancelButtonText = "取消",
         MessageBoxImage icon = MessageBoxImage.Information)
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption, MessageBoxButton.OKCancel, icon);
         msg.OkButtonText = okButtonText;
         msg.CancelButtonText = cancelButtonText;

         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message, caption, and Yes/No buttons with custom System.String values for the buttons' text;
      /// and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <param name="yesButtonText">A System.String that specifies the text to display within the Yes button.</param>
      /// <param name="noButtonText">A System.String that specifies the text to display within the No button.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult ShowYesNo(string messageBoxText, string caption = "提示", string yesButtonText = "好的", string noButtonText = "不")
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption, MessageBoxButton.YesNo);
         msg.YesButtonText = yesButtonText;
         msg.NoButtonText = noButtonText;

         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message, caption, Yes/No buttons with custom System.String values for the buttons' text, and icon;
      /// and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <param name="yesButtonText">A System.String that specifies the text to display within the Yes button.</param>
      /// <param name="noButtonText">A System.String that specifies the text to display within the No button.</param>
      /// <param name="icon">A System.Windows.MessageBoxImage value that specifies the icon to display.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult ShowYesNo(string messageBoxText, string caption = "提示",
         string yesButtonText = "好的", string noButtonText = "不",
         MessageBoxImage icon = MessageBoxImage.Information)
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption, MessageBoxButton.YesNo, icon);
         msg.YesButtonText = yesButtonText;
         msg.NoButtonText = noButtonText;

         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message, caption, and Yes/No/Cancel buttons with custom System.String values for the buttons' text;
      /// and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <param name="yesButtonText">A System.String that specifies the text to display within the Yes button.</param>
      /// <param name="noButtonText">A System.String that specifies the text to display within the No button.</param>
      /// <param name="cancelButtonText">A System.String that specifies the text to display within the Cancel button.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult ShowYesNoCancel(string messageBoxText, string caption = "提示",
         string yesButtonText = "好的", string noButtonText = "不", string cancelButtonText = "取消")
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption, MessageBoxButton.YesNoCancel);
         msg.YesButtonText = yesButtonText;
         msg.NoButtonText = noButtonText;
         msg.CancelButtonText = cancelButtonText;

         msg.ShowDialog();

         return msg.Result;
      }

      /// <summary>
      /// Displays a message box that has a message, caption, Yes/No/Cancel buttons with custom System.String values for the buttons' text, and icon;
      /// and that returns a result.
      /// </summary>
      /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
      /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
      /// <param name="yesButtonText">A System.String that specifies the text to display within the Yes button.</param>
      /// <param name="noButtonText">A System.String that specifies the text to display within the No button.</param>
      /// <param name="cancelButtonText">A System.String that specifies the text to display within the Cancel button.</param>
      /// <param name="icon">A System.Windows.MessageBoxImage value that specifies the icon to display.</param>
      /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
      public static MessageBoxResult ShowYesNoCancel(string messageBoxText, string caption = "提示",
         string yesButtonText = "好的", string noButtonText = "不", string cancelButtonText = "取消",
         MessageBoxImage icon = MessageBoxImage.Information)
      {
         AduMessageBoxWindow msg = new AduMessageBoxWindow(messageBoxText, caption, MessageBoxButton.YesNoCancel, icon);
         msg.YesButtonText = yesButtonText;
         msg.NoButtonText = noButtonText;
         msg.CancelButtonText = cancelButtonText;

         msg.ShowDialog();

         return msg.Result;
      }

   }
}
