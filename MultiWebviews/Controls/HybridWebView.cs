using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace MultiWebviews.Controls
{


    public class HybridWebView : WebView
    {

        Action<string> action;

        public static readonly BindableProperty messageContentProperty =
          BindableProperty.Create(nameof(messageContent), typeof(string), typeof(HybridWebView), string.Empty);

        public string messageContent
        {
            get { return (string)GetValue(messageContentProperty).ToString(); }
            set { SetValue(messageContentProperty, value); }
        }

        public void Cleanup()
        {
            action = null;
        }

        public void InvokeAction(string data)
        {
            if (action == null || data == null)
            {
                return;
            }
            action.Invoke(data);
        }


        public HybridWebView()
        {

            HeightRequest = 20;
            Source = "";
            this.PropertyChanged += HybridWebView_PropertyChanged;

        }

        private void HybridWebView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            if (e.PropertyName.Equals(nameof(messageContent)))
            {

                var htmlSource = new HtmlWebViewSource();
                htmlSource.Html = @"<html>
                                    <head>
                                    <link rel=""stylesheet"" href=""chatmessage-content.css"">
                                    <meta name='viewport' content='width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no'>
                                    </head>
                                    <body style=""background-color: #DDDDDD;"">
<a class=""btn btn-true"" onclick=""setresponseandsubmit('1ca15124-9624-431e-8644-22a5839b7a10')"">test: </a>" + messageContent + " <p>Extra line</p><p>Extra line</p><p>Extra line</p><p>Extra line</p><p>Extra line</p><p>Extra line</p><p>Extra line</p><p>Extra line</p><p>Extra line</p><p>Extra line</p>" +
      "</body></html>";

                Source = htmlSource;

            }

        }
    }

}
