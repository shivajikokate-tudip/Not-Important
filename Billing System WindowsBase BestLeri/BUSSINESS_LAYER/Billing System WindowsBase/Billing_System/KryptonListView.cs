using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using ComponentFactory.Krypton.Toolkit;
//using AC.ExtendedRenderer.Toolkit.Drawing;
//using AC.ExtendedRenderer.Toolkit.Utils;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Collections;

using System.Collections.Specialized;



namespace AC.ExtendedRenderer.Toolkit
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(KryptonListView))]
    public class KryptonListView : ListView
    {
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;
        private IContainer components;
        private ImageList ilCheckBoxes;
        //private ListSortDirection lvwColumnSorter;

        public KryptonListView()
        {
            //this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();
            this.OwnerDraw = true;


                // add Palette Handler
                if (_palette != null)
                    _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

                KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

                _palette = KryptonManager.CurrentGlobalPalette;
                _paletteRedirect = new PaletteRedirect(_palette);

                // Create an instance of a ListView column sorter and assign it 
                // to the ListView control.
                //lvwColumnSorter = new ListSortDirection();
                //this.ListSortDirection = lvwColumnSorter;

            if (_selectEntireRowOnSubItem == true)
            {
                this.FullRowSelect = true;
            }

            //fix the Row height
            //if ((this.SmallImageList == null) && (this.CheckBoxes != true))
                if (this.SmallImageList == null) 
            {
                ImageList il = new ImageList();
                il.ImageSize = new Size(16, 16);
                this.SmallImageList = il;
                _indendFirstItem = true;
            }

            //vista
            //_enableVistaCheckBoxes = Utility.IsVista();

            //for image list
            InitializeComponent();


        }

        Color _gradientStartColor = Color.White;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Color.White")]
        public Color GradientStartColor
        {
            get { return _gradientStartColor; }
            set { _gradientStartColor = value; Invalidate(); }
        }

        Color _gradientEndColor = Color.Gray;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Color.Gray")]
        public Color GradientEndColor
        {
            get { return _gradientEndColor; }
            set { _gradientEndColor = value; Invalidate(); }
        }

        Color _gradientMiddleColor = Color.LightGray;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Color.Gray")]
        public Color GradientMiddleColor
        {
            get { return _gradientMiddleColor; }
            set { _gradientMiddleColor = value; Invalidate(); }
        }

        Boolean _persistentColors = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean PersistentColors
        {
            get { return _persistentColors; }
            set { _persistentColors = value; Invalidate(); }
        }

        Boolean _useStyledColors = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean UseStyledColors
        {
            get { return _useStyledColors; }
            set { _useStyledColors = value; Invalidate(); }
        }

        Boolean _selectEntireRowOnSubItem = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean SelectEntireRowOnSubItem
        {
            get { return _selectEntireRowOnSubItem; }
            set { _selectEntireRowOnSubItem = value; }
        }

        Boolean _indendFirstItem = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean IndendFirstItem
        {
            get { return _indendFirstItem; }
            set { _indendFirstItem = value; }
        }

        Boolean _forceLeftAlign = false;
        [Browsable(false), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean ForceLeftAlign
        {
            get { return _forceLeftAlign; }
            set { _forceLeftAlign = value; }
        }

        Boolean _autoSizeLastColumn = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean AutoSizeLastColumn
        {
            get { return _autoSizeLastColumn; }
            set { _autoSizeLastColumn = value; Invalidate(); }
        }

        Boolean _enableSorting = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean EnableSorting
        {
            get { return _enableSorting; }
            set { _enableSorting = value; }
        }

        Boolean _enableHeaderRendering = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean EnableHeaderRendering
        {
            get { return _enableHeaderRendering; }
            set { _enableHeaderRendering = value; Invalidate(); }
        }

        Boolean _enableHeaderGlow = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean EnableHeaderGlow
        {
            get { return _enableHeaderGlow; }
            set { _enableHeaderGlow = value; Invalidate(); }
        }

        Boolean _enableHeaderHotTrack = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean EnableHeaderHotTrack
        {
            get { return _enableHeaderHotTrack; }
            set { _enableHeaderHotTrack = value; Invalidate(); }
        }

        Boolean _enableVistaCheckBoxes = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean EnableVistaCheckBoxes
        {
            get { return _enableVistaCheckBoxes; }
            set { _enableVistaCheckBoxes = value; Invalidate(); }
        }


        //Draw Item
        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {

            Rectangle rect = e.Bounds;
            Graphics g = e.Graphics;

            //ClearType
            try
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            //g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            if (_palette == null)
            {
                EventArgs Ev = new EventArgs();
                OnGlobalPaletteChanged(this,Ev);
            }

            //set colors
            if (_persistentColors == false)
            {
                //init color values
                if (_useStyledColors == true)
                {
                    _gradientStartColor = Color.FromArgb(255, 246, 215);
                    _gradientEndColor = Color.FromArgb(255, 213, 77);
                    _gradientMiddleColor = Color.FromArgb(252, 224, 133);
                }
                else
                {
                    _gradientStartColor = _palette.ColorTable.StatusStripGradientBegin;
                    _gradientEndColor = _palette.ColorTable.OverflowButtonGradientEnd;
                    _gradientMiddleColor = _palette.ColorTable.StatusStripGradientEnd;
                }
            }

            //BackColors 
            Color gradStartColor = _gradientStartColor;
            Color gradEndColor = _gradientEndColor;
            Color gradMiddleColor = _gradientMiddleColor;
            Color textColor = _palette.ColorTable.StatusStripText;

            //force Left align on items
            if (_forceLeftAlign == true)
            {
                foreach (ColumnHeader col in this.Columns)
                {
                    col.TextAlign = HorizontalAlignment.Left;
                }
            }

            ListViewItemStates sta = e.State;
            Console.Write(sta);

            if (this.View == View.Details)
            {
                if (((e.State & ListViewItemStates.Selected) != 0) && (e.Item.Selected == true))
                {
                    // Draw the background and focus rectangle for a selected item.
                    //DrawingMethods.DrawBlendGradient(e.Graphics, e.Bounds, gradStartColor, gradEndColor, gradMiddleColor, 90F);

                        DrawGradient(e.Graphics, e.Bounds, gradStartColor, gradEndColor);
                    
                    //text
                    e.DrawText();

                    //CheckBox present?
                    if (this.CheckBoxes == true)
                    {
                        string CheckState;
                        if (e.Item.Checked == true)
                        {
                            CheckState = "V";
                        }
                        else
                        {
                            CheckState = "O";
                        }
                        e.Graphics.DrawString(CheckState, this.Font, new SolidBrush(textColor), rect);
                        rect.Offset(19, 0);
                    }

                    //Picture Present?
                        if (this.SmallImageList != null && e.Item.ImageIndex >= 0 && e.Item.ImageIndex < SmallImageList.Images.Count)
                        {
                            this.SmallImageList.Draw(g, rect.X, rect.Y, 16, 16, e.Item.ImageIndex);
                        }

                    
                    //e.DrawFocusRectangle();
                }
                else
                {
                    // Draw the background for an unselected item.
                    e.DrawDefault = true;
                }
            }
            // Draw the item text for views other than the Details view.
            else
            {
                // Draw the background for an unselected item.
                e.DrawDefault = true;
            }

        }


        //Draw SubItem
        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            Rectangle rect = e.Bounds;
            Graphics g = e.Graphics;

           //ClearType
           try
           {
               e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
           }
           catch (Exception ex)
           {
               Console.Write(ex.Message);
           }

            //set colors
           Color textColor = _palette.ColorTable.StatusStripText;
            if (_persistentColors == false)
            {
                //init color values
                if (_useStyledColors == true)
                {
                    _gradientStartColor = Color.FromArgb(255, 246, 215);
                    _gradientEndColor = Color.FromArgb(255, 213, 77);
                    _gradientMiddleColor = Color.FromArgb(252, 224, 133);
                     textColor = _palette.ColorTable.MenuItemText;
                }
                else
                {
                    _gradientStartColor = _palette.ColorTable.StatusStripGradientBegin;
                    _gradientEndColor = _palette.ColorTable.OverflowButtonGradientEnd;
                    _gradientMiddleColor = _palette.ColorTable.StatusStripGradientEnd;
                     textColor = _palette.ColorTable.StatusStripText;
                }
            }

            //BackColors 

            Color gradStartColor = _gradientStartColor;
            Color gradEndColor = _gradientEndColor;
            Color gradMiddleColor = _gradientMiddleColor;


            //force Left align on items
            if (_forceLeftAlign == true)
            {
                foreach (ColumnHeader col in this.Columns)
                {
                    col.TextAlign = HorizontalAlignment.Left;
                }
            }

            //ListViewItemStates sta = e.ItemState;
            //Console.Write(sta);

            if (this.View == View.Details)
            {
                if ((e.ItemState & ListViewItemStates.Selected) != 0) 
                {
                    // Draw the background and focus rectangle for a selected item.
                    //DrawingMethods.DrawBlendGradient(e.Graphics, e.Bounds, gradStartColor, gradEndColor, gradMiddleColor, 90F);
                    DrawGradient(e.Graphics, e.Bounds, gradStartColor, gradEndColor);
                    
                    //CheckBox present?
                    if ((this.CheckBoxes == true) && (e.ColumnIndex==0))
                    {
                        string CheckState = "V";
                        Image Check ;
                        if (e.Item.Checked == true)
                        {
                            CheckState = "V";
                            if (_enableVistaCheckBoxes == true)
                            {
                                Check = ilCheckBoxes.Images[3];
                            }
                            else
                            {
                                Check = ilCheckBoxes.Images[1];
                            }
                            
                        }
                        else
                        {
                            CheckState = "O";
                            if (_enableVistaCheckBoxes == true)
                            {
                                Check = ilCheckBoxes.Images[2];
                            }
                            else
                            {
                                Check = ilCheckBoxes.Images[0];
                            }
                        }

                        ////vista pixel fix
                        //if (Utility.IsVista() == true)
                        //{
                        //    rect.Offset(-2, 0);
                        //}

                        //e.Graphics.DrawString(CheckState, this.Font, new SolidBrush(textColor), rect);
                        g.DrawImage(Check,rect.X + 4, rect.Y, 16, 16);
                        rect.Offset(19, 0);

                        ////vista pixel fix
                        //if (Utility.IsVista() == true)
                        //{
                        //    rect.Offset(-1, 0);
                        //}
                    }

                    //Picture Present?
                    if (e.ColumnIndex==0)
                    {
                        try
                        {
                            this.SmallImageList.Draw(g, rect.X+4, rect.Y, 16, 16, e.Item.ImageIndex);
                            if (_indendFirstItem == true)
                            {
                                rect.Offset(16, 0);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.Message);
                            if (_indendFirstItem == true)
                            {
                                rect.Offset(16, 0);
                            }
                        }
                    }
                    rect.Offset(4, 2);
                    e.Graphics.DrawString(e.SubItem.Text,this.Font,new SolidBrush(textColor),rect);
                    //e.DrawFocusRectangle();
                }
                else
                {
                    // Draw the background for an unselected item.
                    e.DrawDefault = true;
                }

            }
            // Draw the item text for views other than the Details view.
            else
            {
                // Draw the background for an unselected item.
                e.DrawDefault = true;
            }

        }
        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {

            if (_enableHeaderRendering == true)
            {
            Rectangle rect = e.Bounds;
            rect.Height = rect.Height - 2;
            rect.Width = rect.Width-0;
            Graphics g = e.Graphics;

            Point mouse = new Point();
            mouse = PointToClient(Control.MousePosition);

            //temp.X -= listView1.Left; //If you are writing your own control, these two lines are not necessary
            //temp.Y -= listView1.Top;  //If you are writing your own control, these two lines are not necessary

            //Header HotTrack
            bool bHot = false;
                if (_enableHeaderHotTrack)
            {
                Invalidate();

                Rectangle mouserect = new Rectangle();
                mouserect = e.Bounds;
                mouserect.Width += 2; //expand the rectangle to make the check more stable
                mouserect.Height += 2;

                if (mouserect.Contains(mouse))
                {
                    bHot = true;
                }
            }

            //ClearType
            try
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            //set colors
            Color gradStartColor;
            Color gradEndColor;
            Color gradMiddleColor;
                Color borderColor = _palette.ColorTable.ToolStripBorder;
                Color textColor = _palette.ColorTable.StatusStripText;

                if (e.State == ListViewItemStates.Selected)
                {
                    gradStartColor = Color.White;// _palette.ColorTable.ButtonSelectedGradientBegin;
                    gradMiddleColor = _palette.ColorTable.ButtonCheckedGradientEnd;
                    gradEndColor = _palette.ColorTable.ButtonCheckedGradientBegin;
                    textColor = _palette.ColorTable.MenuItemText;
                }
                else
                {
                    if (bHot)
                    {
                        gradStartColor = Color.White;// _palette.ColorTable.ButtonSelectedGradientBegin;
                        gradMiddleColor = _palette.ColorTable.ButtonSelectedGradientEnd;
                        gradEndColor = _palette.ColorTable.ButtonSelectedGradientBegin;
                        textColor = _palette.ColorTable.MenuItemText;
                    }
                    else
                    {
                        gradStartColor = Color.White;//_palette.ColorTable.ToolStripGradientBegin;
                        gradMiddleColor = _palette.ColorTable.ToolStripGradientEnd;
                        gradEndColor = _palette.ColorTable.ToolStripGradientBegin;
                        textColor = _palette.ColorTable.MenuItemText;
                    }
                }


            //Empty Area
            g.FillRectangle(new SolidBrush(Color.White),rect);

            //Fill Gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, gradStartColor, gradEndColor, LinearGradientMode.Vertical))
            {
                //g.FillRectangle(brush, rect);
                if (!_enableHeaderGlow)
                {
                    DrawBlendGradient(g, rect, gradStartColor, gradEndColor, gradMiddleColor, 90F);
                }
                else
                {
                    DrawListViewHeader(g, rect, gradStartColor, gradMiddleColor,gradEndColor, Color.White, 90F);
                }
            }

            //DrawBorder
            g.DrawRectangle(new Pen(borderColor), rect);

            //Draw light lines
            //oriz
            g.DrawLine(new Pen(Color.White), new Point(rect.X + 1, rect.Y + 1), new Point(rect.X + rect.Width - 1, rect.Y + 1));
            //vert
            g.DrawLine(new Pen(Color.White), new Point(rect.X + 1, rect.Y + 1), new Point(rect.X + 1, rect.Y + rect.Height -1));


            if (e.ColumnIndex == this.Columns.Count - 1)
            {
                //last border
                g.DrawLine(new Pen(borderColor), new Point(rect.X + rect.Width - 1, rect.Y ), new Point(rect.X + rect.Width - 1, rect.Y  + rect.Height + 0));

            }

            if (e.State == ListViewItemStates.Selected)
            {
                rect.Offset(3, 5);
            }
            else
            {
                rect.Offset(2, 4);
            }
            
            		StringFormat TextFormat = new StringFormat();
                    TextFormat.FormatFlags = StringFormatFlags.NoWrap;
                    g.DrawString(e.Header.Text, this.Font, new SolidBrush(textColor), rect, TextFormat);
            //e.DrawText();

                //Draw sort indicator
                /*
                    if (this.Columns[e.ColumnIndex].Tag != null)
                    {
                        SortOrder sort = (SortOrder)this.Columns[e.ColumnIndex].Tag;

                        // Prepare arrow
                        if (sort == SortOrder.Ascending)
                        {
                            // draw arrow
                            g.FillRectangle(new SolidBrush(Color.Red), rect.X + rect.Width - 8, rect.Y, 8, 8);
                        }
                        else if (sort == SortOrder.Descending)
                        {
                            g.FillRectangle(new SolidBrush(Color.Green), rect.X + rect.Width - 8, rect.Y, 8, 8);
                        }

                    }
                 */
            }
        else
         {
             e.DrawDefault = true;
         }

        }


        #region Variables & Properties
        /// <summary>
        /// If this variable is true, then 
        /// subitems for an item is added 
        /// automatically, if not present.
        /// </summary>
        private bool addSubItem = false;
        public bool AddSubItem
        {
            set
            {
                this.addSubItem = value;
            }
        }

        /// <summary>
        /// This variable tells whether the combo box 
        /// is needed to be displayed after its selection
        /// is changed
        /// </summary>
        private bool hideComboAfterSelChange = false;
        public bool HideComboAfterSelChange
        {
            set
            {
                this.hideComboAfterSelChange = value;
            }
        }

        /// <summary>
        /// Represents current row
        /// </summary>
        private int row = -1;

        /// <summary>
        /// Represents current column
        /// </summary>
        private int col = -1;

        /// <summary>
        /// Textbox to display in the editable cells
        /// </summary>
        private TextBox textBox = new TextBox();

        /// <summary>
        /// Combo box to display in the associated cells
        /// </summary>
        private ComboBox combo = new ComboBox();

        /// <summary>
        /// This is a flag variable. This is used to determine whether
        /// Mousebutton is pressed within the listview
        /// </summary>
        private bool mouseDown = false;

        /// <summary>
        /// To store, subitems that contains comboboxes and text boxes
        /// </summary>
        private Hashtable customCells = new Hashtable();
        #endregion

        protected override void OnMouseDown(MouseEventArgs e)
        {
            try
            {
                // Mouse down happened inside listview
                mouseDown = true;

                // Hide the controls
                //this.textBox.Hide();
                //this.combo.Hide();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            try
            {
                // Hide the controls
                this.textBox.Visible = this.combo.Visible = false ;

                // If no mouse down happned in this listview, 
                // no need to show anything
                if (!mouseDown)
                {
                    return;
                }

                // The listview should be having the following properties enabled
                // 1. FullRowSelect = true
                // 2. View should be Detail;
                if (!this.FullRowSelect || this.View != View.Details)
                {
                    return;
                }

                // Reset the mouse down flag
                mouseDown = false;

                // Get the subitem rect at the mouse point.
                // Remeber that the current row index and column index will also be
                // Modified within the same method
                RECT rect = this.GetSubItemRect(new Point(e.X, e.Y));

                // If the above method is executed with any error,
                // The row index and column index will be -1;
                if (this.row != -1 && this.col != -1)
                {
                    // Check whether combobox or text box is set for the current cell
                    SubItem cell = GetKey(new SubItem(this.row, this.col));

                    if (cell != null)
                    {
                        // Set the size of the control(combobox/editbox)
                        // This should be composed of the height of the current items and
                        // width of the current column
                        Size sz = new Size(this.Columns[col].Width, Items[row].Bounds.Height);

                        // Determine the location where the control(combobox/editbox) to be placed
                        Point location = col == 0 ? new Point(0, rect.top) : new Point(rect.left, rect.top);

                        ValidateAndAddSubItems();

                        // Decide which conrol to be displayed.
                        if (this.customCells[cell] == null)
                        {
                            this.ShowTextBox(location, sz);
                        }
                        else
                        {
                            this.ShowComboBox(location, sz, (StringCollection)this.customCells[cell]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            //Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
                base.OnMouseEnter(e);
                //Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
           base.OnMouseMove(e);
        }
        protected override void OnItemMouseHover(ListViewItemMouseHoverEventArgs e)
        {
            base.OnItemMouseHover(e);
        }

        //protected override void OnColumnClick(ColumnClickEventArgs e)
        //{
        //    base.OnColumnClick(e);

        //    if (_enableSorting == true)
        //    {
        //        // Determine if clicked column is already the column that is being sorted.
        //        if (e.Column == lvwColumnSorter.SortColumn)
        //        {
        //            // Reverse the current sort direction for this column.
        //            if (lvwColumnSorter.Order == SortOrder.Ascending)
        //            {
        //                lvwColumnSorter.Order = SortOrder.Descending;
        //            }
        //            else
        //            {
        //                lvwColumnSorter.Order = SortOrder.Ascending;
        //            }
        //        }
        //        else
        //        {
        //            // Set the column number that is to be sorted; default to ascending.
        //            lvwColumnSorter.SortColumn = e.Column;
        //            lvwColumnSorter.Order = SortOrder.Ascending;
        //        } 

        //        //set info for sort image
        //        //CleanColumnsTag();
        //        //this.Columns[e.Column].Tag = lvwColumnSorter.Order;

        //        // Perform the sort with these new sort options.
        //        this.Sort();
        //    }
        //}

               private void CleanColumnsTag()
        {
            int i;

            for (i = 0; i<this.Columns.Count; i++)
            {
                this.Columns[i].Tag = null;
            }
            Invalidate();
        }


        [PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message message)
        {
            const int WM_PAINT = 0xf;
            const int WM_NCHITTEST = 0x84;

            if (_autoSizeLastColumn)
            {
                // if the control is in details view mode and columns
                // have been added, then intercept the WM_PAINT message
                // and reset the last column width to fill the list view
                switch (message.Msg)
                {
                    case WM_PAINT:
                        if (this.View == View.Details && this.Columns.Count > 0)
                            this.Columns[this.Columns.Count - 1].Width = -2;
                        for (int i = 0; i < this.Columns.Count -1; i++)
                        {
                            this.Columns[i].Width = this.Columns[i].Width;
                        }
                        break;

                    case WM_NCHITTEST:
                        //DRAWITEMSTRUCT dis = (DRAWITEMSTRUCT)Marshal.PtrToStructure(message.LParam, typeof(DRAWITEMSTRUCT));
                        
                        //ColumnHeader ch = this.Columns[dis.itemID];
                        break;
                }

            }
            // pass messages on to the base control for processing
            base.WndProc(ref message);

        }


        //Kripton Palette Events
        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            if (_palette != null)
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect.Target = _palette;

            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                //repaint with new values

                //set colors
                if (_persistentColors == false)
                {
                    //init color values
                    if (_useStyledColors == true)
                    {
                        _gradientStartColor = Color.FromArgb(255, 246, 215);
                        _gradientEndColor = Color.FromArgb(255, 213, 77);
                        _gradientMiddleColor = Color.FromArgb(252, 224, 133);
                    }
                    else
                    {
                        _gradientStartColor = _palette.ColorTable.StatusStripGradientBegin;
                        _gradientEndColor = _palette.ColorTable.OverflowButtonGradientEnd;
                        _gradientMiddleColor = _palette.ColorTable.StatusStripGradientEnd;
                    }
                }
            }

            Invalidate();
        }


        //Kripton Palette Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

                if (_palette != null)
                {
                    _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                    _palette = null;
                }


                KryptonManager.GlobalPaletteChanged -= new EventHandler(OnGlobalPaletteChanged);
            }

            base.Dispose(disposing);
        }

        public static void DrawGradient(Graphics g, Rectangle rect, Color DarkColor, Color LightColor)
        {
            using (LinearGradientBrush lb = new LinearGradientBrush(rect, LightColor, DarkColor, LinearGradientMode.Vertical))
            {
                Blend blend1 = new Blend(4);
                blend1.Positions[0] = 0f;
                blend1.Factors[0] = 0.9f;
                blend1.Positions[1] = 0.4f;
                blend1.Factors[1] = 0.5f;
                blend1.Positions[2] = 0.4f;
                blend1.Factors[2] = 0.2f; //0 darker 0.3 lighter (middle line)
                blend1.Positions[3] = 1f;
                blend1.Factors[3] = 1f;
                lb.Blend = blend1;
                g.FillRectangle(lb, rect);
            }
        }

        public static void DrawBlendGradient(Graphics g, Rectangle rect, Color LightColor, Color DarkColor, Color MiddleColor, float Angle)
        {
            ColorBlend blend = new ColorBlend(4);

            blend.Positions[0] = 0f;
            blend.Colors[0] = LightColor;

            blend.Positions[1] = 0.5f;
            blend.Colors[1] = DarkColor;

            blend.Positions[2] = 0.5f;
            blend.Colors[2] = DarkColor;

            blend.Positions[3] = 1f;
            blend.Colors[3] = MiddleColor;

            using (LinearGradientBrush b = new LinearGradientBrush(rect, blend.Colors[0], blend.Colors[3], Angle))
            {
                b.InterpolationColors = blend;

                g.FillRectangle(Brushes.White, rect);
                g.FillRectangle(b, rect);
            }
        }

        public static void DrawListViewHeader(Graphics g, Rectangle rect, Color LightColor, Color MiddleColor, Color DarkColor, Color ExtraColor, float Angle)
        {

            //Split the area, new half height
            int HalfSize = (int)rect.Height / 2 - 2;

            Rectangle Newrect = new Rectangle(rect.X, rect.Y + HalfSize, rect.Width, rect.Height - HalfSize);

            //check on all whites
            if ((MiddleColor == Color.White) && (DarkColor == Color.White))
            {
                MiddleColor = Color.WhiteSmoke;
                DarkColor = Color.Snow;
            }

            //fill the light part (top)
            using (LinearGradientBrush b = new LinearGradientBrush(rect, LightColor, MiddleColor, Angle))
            {
                //DrawGradient(g, rect, MiddleColor, LightColor);
                g.FillRectangle(b, rect);
            }


            //Fill the rest
            using (LinearGradientBrush b = new LinearGradientBrush(Newrect, MiddleColor, DarkColor, Angle))
            {
                g.FillRectangle(b, Newrect);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonListView));
            this.ilCheckBoxes = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ilCheckBoxes
            // 
            this.ilCheckBoxes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilCheckBoxes.ImageStream")));
            this.ilCheckBoxes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilCheckBoxes.Images.SetKeyName(0, "XpNotChecked.gif");
            this.ilCheckBoxes.Images.SetKeyName(1, "XpChecked.gif");
            this.ilCheckBoxes.Images.SetKeyName(2, "VistaNotChecked.png");
            this.ilCheckBoxes.Images.SetKeyName(3, "VistaChecked.png");
            this.ResumeLayout(false);

            
            // Text box
            this.textBox.Visible = false;
            //textBox.BorderStyle = BorderStyle.FixedSingle;
            this.textBox.Leave += new EventHandler(textBox_Leave);
            this.textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            // Combo box
            this.combo.Visible = false;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.combo);
            this.combo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.combo.SelectedIndexChanged += new EventHandler(combo_SelectedIndexChanged);
        }
        #region The RECT structure
        /// <summary>
        /// This struct type will be used as the oupput 
        /// param of the SendMessage( GetSubItemRect ). 
        /// Actually it is a representation for the strucure 
        /// RECT in Win32
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        #endregion        
        #region Win32 Class
        /// <summary>
        /// Summary description for Win32.
        /// </summary>
        internal class Win32
        {
            /// <summary>
            /// This is the number of the message for getting the sub item rect.
            /// </summary>
            public const int LVM_GETSUBITEMRECT = (0x1000) + 56;

            /// <summary>
            /// As we are using the detailed view for the list,
            /// LVIR_BOUNDS is the best parameters for RECT's 'left' member.
            /// </summary>
            public const int LVIR_BOUNDS = 0;

            /// <summary>
            /// Sending message to Win32
            /// </summary>
            /// <param name="hWnd">Handle to the control</param>
            /// <param name="messageID">ID of the message</param>
            /// <param name="wParam"></param>
            /// <param name="lParam"></param>
            /// <returns></returns>
            [DllImport("user32.dll", SetLastError = true)]
            public static extern int SendMessage(IntPtr hWnd, int messageID, int wParam, ref RECT lParam);
        }
        #endregion

#region Methods
		
		/// <summary>
		/// Initializes the text box and combo box
		/// </summary>

		/// <summary>
		/// This method will send LVM_GETSUBITEMRECT message to 
		/// get the current subitem bouds of the listview
		/// </summary>
		/// <param name="clickPoint"></param>
		/// <returns></returns>
		private RECT GetSubItemRect(Point clickPoint)
		{
			// Create output param
			RECT subItemRect = new RECT();

			// Reset the indices
			this.row = this.col = -1;
			
			// Check whether there is any item at the mouse point
			ListViewItem item = this.GetItemAt(clickPoint.X, clickPoint.Y);

			if(item != null )
			{
				for(int index = 0; index < this.Columns.Count; index++)
				{				
					// We need to pass the 1 based index of the subitem.
					subItemRect.top = index + 1; 

					// To get the boudning rectangle, as we are using the report view
					subItemRect.left = Win32.LVIR_BOUNDS;
					try
					{
						// Send Win32 message for getting the subitem rect. 
						// result = 0 means error occuured
						int result = Win32.SendMessage(this.Handle, Win32.LVM_GETSUBITEMRECT, item.Index, ref subItemRect);
						if( result != 0 )
						{
							// This case happens when items in the first columnis selected.
							// So we need to set the column number explicitly
							if(clickPoint.X < subItemRect.left)
							{
								this.row = item.Index;
								this.col= 0;
								break;
							}
							if(clickPoint.X >= subItemRect.left & clickPoint.X <= 
								subItemRect.right)
							{
								this.row = item.Index;
								// Add 1 because of the presence of above condition
								this.col = index + 1;
								break;
							}
						}
						else
						{
							// This call will create a new Win32Exception with the last Win32 Error.
							throw new Win32Exception();
						}
					}
					catch( Win32Exception ex )
					{
						Trace.WriteLine( string.Format("Exception while getting subitem rect, {0}", ex.Message ));
					}
				}
			}			
			return subItemRect;
		}

		/// <summary>
		/// Set a text box in a cell
		/// </summary>
		/// <param name="row">The 0-based index of the item.  Give -1 if you
		///					  want to set a text box for every items for a
		///					  given "col" variable.
		///	</param>
		/// <param name="col">The 0-based index of the column. Give -1 if you
		///					  want to set a text box for every subitems for a
		///					  given "row" variable.
		///	</param>
		public void AddEditableCell( int row, int col )
		{
			// Add the cell into the hashtable
			// Value is setting as null because it is an editable cell
			this.customCells[new SubItem( row, col )] = null;
		}

		/// <summary>
		/// Set a combobox in a cell
		/// </summary>
		/// <param name="row"> The 0-based index of the item.  Give -1 if you
		///					   want to set a combo box for every items for a
		///					   given "col" variable.
		///	</param>
		/// <param name="col"> The 0-based index of the column. Give -1 if you
		///					   want to set a combo box for every subitems for a
		///					   given "row" variable.
		///	</param>
		/// <param name="data"> Items of the combobox 
		/// </param>
		public void AddComboBoxCell( int row, int col, StringCollection data )
		{
			// Add the cell into the hashtable
			// Value for the hashtable is the combobox items
			this.customCells[new SubItem( row, col )] = data;
		}

		/// <summary>
		/// Set a combobox in a cell
		/// </summary>
		/// <param name="row"> The 0-based index of the item.  Give -1 if you
		///					   want to set a combo box for every items for a
		///					   given "col" variable.
		///	</param>
		/// <param name="col"> The 0-based index of the column. Give -1 if you
		///					   want to set a combo box for every subitems for a
		///					   given "row" variable.
		///	</param>
		/// <param name="data"> Items of the combobox 
		/// </param>
		public void AddComboBoxCell( int row, int col, string[] data )
		{
			try
			{
				StringCollection param = new StringCollection();
				param.AddRange( data );
				this.AddComboBoxCell( row, col, param );
			}
			catch( Exception ex )
			{
				Trace.WriteLine( ex.ToString());
			}
		}

		/// <summary>
		/// This method will display the combobox
		/// </summary>
		/// <param name="location">Location of the combobox</param>
		/// <param name="sz">Size of the combobox</param>
		/// <param name="data">Combobox items</param>
		private void ShowComboBox( Point location, Size sz, StringCollection data )
		{
			try
			{
				// Initialize the combobox
				combo.Size = sz;
				combo.Location = location;
				// Add items
				combo.Items.Clear();
				foreach( string text in data )
				{
					combo.Items.Add( text );
				}			
				// Set the current text, take it from the current listview cell
				combo.Text = this.Items[row].SubItems[col].Text;
				// Calculate and set drop down width
				combo.DropDownWidth = this.GetDropDownWidth(data);
				// Show the combo
				combo.Show();
			}
			catch( ArgumentOutOfRangeException )
			{
				// Sink
			}
		}

		/// <summary>
		/// This method will display the textbox
		/// </summary>
		/// <param name="location">Location of the textbox</param>
		/// <param name="sz">Size of the textbox</param>
		private void ShowTextBox( Point location, Size sz )
		{
			try
			{
				// Initialize the textbox
				textBox.Size = sz;
				textBox.Location = location;
				// Set text, take it from the current listview cell
				textBox.Text = this.Items[row].SubItems[col].Text;
				// Shopw the text box
				textBox.Show();
				textBox.Focus();
			}
			catch( ArgumentOutOfRangeException )
			{
				// Sink
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>

		/// <summary>
		/// 
		/// </summary>
		private void ValidateAndAddSubItems()
		{
			try
			{
				while( this.Items[this.row].SubItems.Count < this.Columns.Count && this.addSubItem )
				{
					this.Items[this.row].SubItems.Add("");
				}
			}
			catch( Exception ex )
			{
				Trace.WriteLine( ex.ToString());
			}
		}

		/// <summary>
		/// This message will get the largest text from the given
		/// stringarray, and will calculate the width of a control which 
		/// will contain that text.
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		private int GetDropDownWidth( StringCollection data )
		{
			// If array is empty just return the combo box width
			if( data.Count == 0 )
			{
				return this.combo.Width;
			}
			
			// Set the first text as the largest
			string maximum = data[0];

			// Now iterate thru each string, to findout the
			// largest
			foreach( string text in data )
			{
				if( maximum.Length <  text.Length )
				{
					maximum = text;
				}
			}
			// Calculate and return the width .
			return (int)(this.CreateGraphics().MeasureString( maximum , this.Font ).Width);
		}


        #region SubItem Class
        /// <summary>
        /// This class is used to represent 
        /// a listview subitem.
        /// </summary>
        internal class SubItem
        {
            /// <summary>
            /// Item index
            /// </summary>
            public readonly int row;

            /// <summary>
            /// Subitem index
            /// </summary>
            public readonly int col;

            /// <summary>
            /// Parameterized contructor
            /// </summary>
            /// <param name="row"></param>
            /// <param name="col"></param>
            public SubItem(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
        }
        #endregion


		/// <summary>
		/// For this method, we will get a Subitem. 
		/// Then we will iterate thru each of the keys and will 
		/// check whther any key contains the given cells row/column.
		/// If it is not found we will check for -1 in any one
		/// </summary>
		/// <param name="cell"></param>
		/// <returns></returns>
		private SubItem GetKey( SubItem cell )
		{
			try
			{
				foreach( SubItem key in this.customCells.Keys )
				{
					// Case 1: Any particular cells is  enabled for a control(Textbox/combobox)
					if( key.row == cell.row && key.col == cell.col )
					{
						return key;
					}
						// Case 2: Any particular column is  enabled for a control(Textbox/combobox)
					else if( key.row == -1 && key.col == cell.col )
					{
						return key;
					}
						// Entire col for a row is is  enabled for a control(Textbox/combobox)
					else if( key.row == cell.row && key.col == -1 )
					{
						return key;
					}
						// All cells are enabled for a control(Textbox/combobox)
					else if( key.row == -1 && key.col == -1 )
					{
						return key;
					}
				}
			}
			catch( Exception ex )
			{
				Trace.WriteLine( ex.ToString());
			}
			return null;
		}

		/// <summary>
		/// This event handler wll set the current text in the textbox
		/// as the listview's current cell's text, while the textbox 
		/// focus is lost
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBox_Leave(object sender, EventArgs e)
		{
			try
			{
				if( this.row != -1 && this.col != -1 )
				{
					this.Items[row].SubItems[col].Text = this.textBox.Text;
					this.textBox.Hide();
				}
			}
			catch( Exception ex )
			{
				Trace.WriteLine( ex.ToString());
			}
		}
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //if (this.row != -1 && this.col != -1)
                //{
                //    this.Items[row].SubItems[col].Text = this.textBox.Text;
                //    //this.textBox.Hide();
                //}
                if ((int)e.KeyChar == 13)
                {
                    textBox_Leave(sender, e);
                    //this.Items[row].SubItems[col].Text = this.textBox.Text;
                    //MessageBox.Show(""); 

                    //RECT rect = this.GetSubItemRect(new Point(e.X, e.Y));

                    if (this.textBox.Text.Length > 0)
                        Items[row].Checked = true;
                    else
                        Items[row].Checked= false ;
                    row = ++row;
                    Size sz = new Size(Items[row].SubItems[col].Bounds.Width, Items[row].SubItems[col].Bounds.Height);

                        // Determine the location where the control(combobox/editbox) to be placed
                    //Point location = col == 0 ? new Point(0, this.textBox.Top) : new Point(this.textBox.Left, this.textBox.Top+this.textBox.Height);
                    Point location = col == 0 ? new Point(0, this.textBox.Top) : new Point(this.textBox.Left,Items[row].SubItems[col].Bounds.Y);
                        ShowTextBox(location, sz);

                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }
		/// <summary>
		/// This event handler wll set the current text in the combobox
		/// as the listview's current cell's text, while the combobox 
		/// selection is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if( this.row != -1 && this.col != -1 )
				{
					this.Items[row].SubItems[col].Text = this.combo.Text;
					this.combo.Visible = !this.hideComboAfterSelChange;		
				}
			}
			catch( Exception ex )
			{
				Trace.WriteLine( ex.ToString());
			}
		}
		#endregion
    }
}

