
//------------------------------------------------------------------------------

//  <auto-generated>
//      This code was generated by:
//        TerminalGuiDesigner v1.0.25.0
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// -----------------------------------------------------------------------------
namespace Zensurrechner_Console {
    using System;
    using Terminal.Gui;
    
    
    public partial class Programm_sec : Terminal.Gui.Window {
        
        private Terminal.Gui.ColorScheme blueOnBlack;
        
        private Terminal.Gui.ColorScheme tgDefault;
        
        private Terminal.Gui.ColorScheme greyOnBlack;
        
        private Terminal.Gui.Label label;
        
        private Terminal.Gui.Button pointadding_btn;
        
        private Terminal.Gui.Button list_btn;
        
        private Terminal.Gui.Button resetAll_btn;
        
        private void InitializeComponent() {
            this.resetAll_btn = new Terminal.Gui.Button();
            this.list_btn = new Terminal.Gui.Button();
            this.pointadding_btn = new Terminal.Gui.Button();
            this.label = new Terminal.Gui.Label();
            this.blueOnBlack = new Terminal.Gui.ColorScheme();
            this.blueOnBlack.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightBlue, Terminal.Gui.Color.Black);
            this.blueOnBlack.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.Cyan, Terminal.Gui.Color.Black);
            this.blueOnBlack.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightBlue, Terminal.Gui.Color.BrightYellow);
            this.blueOnBlack.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Cyan, Terminal.Gui.Color.BrightYellow);
            this.blueOnBlack.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Gray, Terminal.Gui.Color.Black);
            this.tgDefault = new Terminal.Gui.ColorScheme();
            this.tgDefault.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.White, Terminal.Gui.Color.Blue);
            this.tgDefault.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightCyan, Terminal.Gui.Color.Blue);
            this.tgDefault.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.Gray);
            this.tgDefault.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.BrightBlue, Terminal.Gui.Color.Gray);
            this.tgDefault.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.Brown, Terminal.Gui.Color.Blue);
            this.greyOnBlack = new Terminal.Gui.ColorScheme();
            this.greyOnBlack.Normal = new Terminal.Gui.Attribute(Terminal.Gui.Color.DarkGray, Terminal.Gui.Color.Black);
            this.greyOnBlack.HotNormal = new Terminal.Gui.Attribute(Terminal.Gui.Color.DarkGray, Terminal.Gui.Color.Black);
            this.greyOnBlack.Focus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.DarkGray);
            this.greyOnBlack.HotFocus = new Terminal.Gui.Attribute(Terminal.Gui.Color.Black, Terminal.Gui.Color.DarkGray);
            this.greyOnBlack.Disabled = new Terminal.Gui.Attribute(Terminal.Gui.Color.DarkGray, Terminal.Gui.Color.Black);
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Visible = true;
            this.ColorScheme = this.tgDefault;
            this.Modal = false;
            this.IsMdiContainer = false;
            this.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.Border.Effect3D = false;
            this.Border.Effect3DBrush = null;
            this.Border.DrawMarginFrame = true;
            this.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Title = "Zensurrechner";
            this.label.Width = 4;
            this.label.Height = 2;
            this.label.X = Pos.Center();
            this.label.Y = 0;
            this.label.Visible = true;
            this.label.ColorScheme = this.tgDefault;
            this.label.Data = "label";
            this.label.Text = "Willkommen zum Zensurenrechner.";
            this.label.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.Add(this.label);
            this.pointadding_btn.Width = 25;
            this.pointadding_btn.Height = 1;
            this.pointadding_btn.X = Pos.Center();
            this.pointadding_btn.Y = Pos.Center() - 5;
            this.pointadding_btn.Visible = true;
            this.pointadding_btn.Data = "pointadding_btn";
            this.pointadding_btn.Text = "Punkt Notenausrechner";
            this.pointadding_btn.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.pointadding_btn.IsDefault = false;
            this.Add(this.pointadding_btn);
            this.list_btn.Width = 26;
            this.list_btn.Height = 1;
            this.list_btn.X = Pos.Center();
            this.list_btn.Y = Pos.Center() - 3;
            this.list_btn.Visible = true;
            this.list_btn.Data = "list_btn";
            this.list_btn.Text = "Auflistung der Klassen";
            this.list_btn.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.list_btn.IsDefault = false;
            this.Add(this.list_btn);
            this.resetAll_btn.Width = 14;
            this.resetAll_btn.Height = 1;
            this.resetAll_btn.X = Pos.Center();
            this.resetAll_btn.Y = Pos.Bottom(list_btn) + 5;
            this.resetAll_btn.Visible = true;
            this.resetAll_btn.Data = "resetAll_btn";
            this.resetAll_btn.Text = "Reset All!";
            this.resetAll_btn.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.resetAll_btn.IsDefault = false;
            this.Add(this.resetAll_btn);
        }
    }
}