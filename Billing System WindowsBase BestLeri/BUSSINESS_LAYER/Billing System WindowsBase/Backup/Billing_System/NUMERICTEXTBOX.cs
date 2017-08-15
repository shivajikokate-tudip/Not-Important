using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BILLING_SYSTEM
{
    public class NUMERICTEXTBOX : System.Windows.Forms.TextBox
    {
        private bool _focused;

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (MouseButtons == MouseButtons.None)
            {
                SelectAll();
                _focused = true;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            _focused = false;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (!_focused)
            {
                if (SelectionLength == 0)
                    SelectAll();
                _focused = true;
            }

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
    }

    public class KRYPTONNUMERICTEXTBOX : ComponentFactory.Krypton.Toolkit.KryptonTextBox
    {
        private bool _focused;

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (MouseButtons == MouseButtons.None)
            {
                SelectAll();
                _focused = true;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            _focused = false;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (!_focused)
            {
                if (SelectionLength == 0)
                    SelectAll();
                _focused = true;
            }

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if (base.Text.Trim().Length <= 0) base.Text = "0";
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (base.Text.Trim().Length <= 0) { base.Text = "0"; SelectAll(); }
        }
    }

    public class SELECTALLTEXTTEXTBOX : System.Windows.Forms.TextBox
    {
        private bool _focused;

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (MouseButtons == MouseButtons.None)
            {
                SelectAll();
                _focused = true;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            _focused = false;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (!_focused)
            {
                if (SelectionLength == 0)
                    SelectAll();
                _focused = true;
            }

        }
    }

    public class KRYPTONSELECTALLTEXTTEXTBOX : ComponentFactory.Krypton.Toolkit.KryptonTextBox
    {
        private bool _focused;

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (MouseButtons == MouseButtons.None)
            {
                SelectAll();
                _focused = true;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            _focused = false;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (!_focused)
            {
                if (SelectionLength == 0)
                    SelectAll();
                _focused = true;
            }

        }
    }
}
