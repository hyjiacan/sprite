using System;
using System.Drawing;
using System.Windows.Forms;

namespace CssSprite
{
    class Logger
    {
        private RichTextBox editor;
        public Logger(RichTextBox editor)
        {
            this.editor = editor;
        }

        public void Success(string text)
        {
            Append(text, Color.DarkGreen);
        }

        public void Info(string text)
        {
            Append(text, Color.Black);
        }

        public void Warn(string text)
        {
            Append(text, Color.Orange);
        }

        public void Error(string text)
        {
            Append(text, Color.Red);
        }

        public void Append(string text, Color color)
        {
            text = $"[{DateTime.Now.ToString("HH:mm:ss")}] {text}";

            var start = editor.Text.Length;

            editor.AppendText(text);
            editor.AppendText("\n");
            editor.Select(start, text.Length);
            editor.SelectionColor = color;
        }
    }
}
