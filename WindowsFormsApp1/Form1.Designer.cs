
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.circleButton = new System.Windows.Forms.Button();
            this.board = new System.Windows.Forms.Panel();
            this.circleRadius = new System.Windows.Forms.TextBox();
            this.circleX = new System.Windows.Forms.TextBox();
            this.circleY = new System.Windows.Forms.TextBox();
            this.circleR = new System.Windows.Forms.TextBox();
            this.XCircle = new System.Windows.Forms.TextBox();
            this.y_Text = new System.Windows.Forms.TextBox();
            this.CircleText = new System.Windows.Forms.Label();
            this.CircleCheck = new System.Windows.Forms.CheckBox();
            this.LineCheck = new System.Windows.Forms.CheckBox();
            this.LineLabel = new System.Windows.Forms.Label();
            this.LineX = new System.Windows.Forms.TextBox();
            this.LineY = new System.Windows.Forms.TextBox();
            this.LineXText = new System.Windows.Forms.TextBox();
            this.LineYText = new System.Windows.Forms.TextBox();
            this.LineX2 = new System.Windows.Forms.TextBox();
            this.LineY2 = new System.Windows.Forms.TextBox();
            this.LineX2Text = new System.Windows.Forms.TextBox();
            this.LineY2Text = new System.Windows.Forms.TextBox();
            this.lineDrawButton = new System.Windows.Forms.Button();
            this.triangleX = new System.Windows.Forms.TextBox();
            this.triangleX2 = new System.Windows.Forms.TextBox();
            this.triangleY = new System.Windows.Forms.TextBox();
            this.triangleY2 = new System.Windows.Forms.TextBox();
            this.trianglXText = new System.Windows.Forms.TextBox();
            this.trianglX2Text = new System.Windows.Forms.TextBox();
            this.trianglYText = new System.Windows.Forms.TextBox();
            this.trianglY2Text = new System.Windows.Forms.TextBox();
            this.TriangleText = new System.Windows.Forms.Label();
            this.TriangleCheck = new System.Windows.Forms.CheckBox();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.triangleX3 = new System.Windows.Forms.TextBox();
            this.triangleY3 = new System.Windows.Forms.TextBox();
            this.trianglX3Text = new System.Windows.Forms.TextBox();
            this.trianglY3Text = new System.Windows.Forms.TextBox();
            this.rectangleX = new System.Windows.Forms.TextBox();
            this.rectangleY = new System.Windows.Forms.TextBox();
            this.rectangleXText = new System.Windows.Forms.TextBox();
            this.rectangleYText = new System.Windows.Forms.TextBox();
            this.rectangleWidth = new System.Windows.Forms.TextBox();
            this.rectangleWidthText = new System.Windows.Forms.TextBox();
            this.rectangleHeight = new System.Windows.Forms.TextBox();
            this.rectangleHeightText = new System.Windows.Forms.TextBox();
            this.rectangleCheck = new System.Windows.Forms.CheckBox();
            this.rectangleText = new System.Windows.Forms.Label();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.PenWidth = new System.Windows.Forms.TextBox();
            this.PenWidthText = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LoadButton = new System.Windows.Forms.Button();
            this.colorBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(529, 138);
            this.circleButton.Margin = new System.Windows.Forms.Padding(2);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(50, 26);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "Draw";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.board.Location = new System.Drawing.Point(-1, -3);
            this.board.Margin = new System.Windows.Forms.Padding(2);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(488, 442);
            this.board.TabIndex = 1;
            this.board.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // circleRadius
            // 
            this.circleRadius.Location = new System.Drawing.Point(529, 31);
            this.circleRadius.Margin = new System.Windows.Forms.Padding(2);
            this.circleRadius.Name = "circleRadius";
            this.circleRadius.Size = new System.Drawing.Size(51, 20);
            this.circleRadius.TabIndex = 2;
            this.circleRadius.Text = "20";
            this.circleRadius.TextChanged += new System.EventHandler(this.circleRadius_TextChanged);
            // 
            // circleX
            // 
            this.circleX.Location = new System.Drawing.Point(529, 74);
            this.circleX.Margin = new System.Windows.Forms.Padding(2);
            this.circleX.Name = "circleX";
            this.circleX.Size = new System.Drawing.Size(51, 20);
            this.circleX.TabIndex = 3;
            this.circleX.Text = "50";
            // 
            // circleY
            // 
            this.circleY.Location = new System.Drawing.Point(529, 117);
            this.circleY.Margin = new System.Windows.Forms.Padding(2);
            this.circleY.Name = "circleY";
            this.circleY.Size = new System.Drawing.Size(51, 20);
            this.circleY.TabIndex = 4;
            this.circleY.Text = "50";
            // 
            // circleR
            // 
            this.circleR.Location = new System.Drawing.Point(529, 9);
            this.circleR.Margin = new System.Windows.Forms.Padding(2);
            this.circleR.Name = "circleR";
            this.circleR.Size = new System.Drawing.Size(51, 20);
            this.circleR.TabIndex = 6;
            this.circleR.Text = "Radius";
            this.circleR.TextChanged += new System.EventHandler(this.circleR_TextChanged);
            // 
            // XCircle
            // 
            this.XCircle.Location = new System.Drawing.Point(529, 52);
            this.XCircle.Margin = new System.Windows.Forms.Padding(2);
            this.XCircle.Name = "XCircle";
            this.XCircle.Size = new System.Drawing.Size(51, 20);
            this.XCircle.TabIndex = 6;
            this.XCircle.Text = "X";
            // 
            // y_Text
            // 
            this.y_Text.Location = new System.Drawing.Point(529, 95);
            this.y_Text.Margin = new System.Windows.Forms.Padding(2);
            this.y_Text.Name = "y_Text";
            this.y_Text.Size = new System.Drawing.Size(51, 20);
            this.y_Text.TabIndex = 6;
            this.y_Text.Text = "Y";
            // 
            // CircleText
            // 
            this.CircleText.AutoSize = true;
            this.CircleText.Location = new System.Drawing.Point(547, 292);
            this.CircleText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CircleText.Name = "CircleText";
            this.CircleText.Size = new System.Drawing.Size(33, 13);
            this.CircleText.TabIndex = 7;
            this.CircleText.Text = "Circle";
            // 
            // CircleCheck
            // 
            this.CircleCheck.AutoSize = true;
            this.CircleCheck.Checked = true;
            this.CircleCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CircleCheck.Location = new System.Drawing.Point(556, 310);
            this.CircleCheck.Margin = new System.Windows.Forms.Padding(2);
            this.CircleCheck.Name = "CircleCheck";
            this.CircleCheck.Size = new System.Drawing.Size(15, 14);
            this.CircleCheck.TabIndex = 8;
            this.CircleCheck.UseVisualStyleBackColor = true;
            this.CircleCheck.CheckedChanged += new System.EventHandler(this.CircleCheck_CheckedChanged);
            // 
            // LineCheck
            // 
            this.LineCheck.AutoSize = true;
            this.LineCheck.Location = new System.Drawing.Point(600, 310);
            this.LineCheck.Margin = new System.Windows.Forms.Padding(2);
            this.LineCheck.Name = "LineCheck";
            this.LineCheck.Size = new System.Drawing.Size(15, 14);
            this.LineCheck.TabIndex = 9;
            this.LineCheck.UseVisualStyleBackColor = true;
            this.LineCheck.CheckedChanged += new System.EventHandler(this.LineCheck_CheckedChanged);
            // 
            // LineLabel
            // 
            this.LineLabel.AutoSize = true;
            this.LineLabel.Location = new System.Drawing.Point(598, 292);
            this.LineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(27, 13);
            this.LineLabel.TabIndex = 10;
            this.LineLabel.Text = "Line";
            // 
            // LineX
            // 
            this.LineX.Location = new System.Drawing.Point(584, 31);
            this.LineX.Margin = new System.Windows.Forms.Padding(2);
            this.LineX.Name = "LineX";
            this.LineX.Size = new System.Drawing.Size(51, 20);
            this.LineX.TabIndex = 3;
            this.LineX.Text = "50";
            // 
            // LineY
            // 
            this.LineY.Location = new System.Drawing.Point(584, 74);
            this.LineY.Margin = new System.Windows.Forms.Padding(2);
            this.LineY.Name = "LineY";
            this.LineY.Size = new System.Drawing.Size(51, 20);
            this.LineY.TabIndex = 4;
            this.LineY.Text = "50";
            // 
            // LineXText
            // 
            this.LineXText.Location = new System.Drawing.Point(584, 9);
            this.LineXText.Margin = new System.Windows.Forms.Padding(2);
            this.LineXText.Name = "LineXText";
            this.LineXText.Size = new System.Drawing.Size(51, 20);
            this.LineXText.TabIndex = 6;
            this.LineXText.Text = "X";
            // 
            // LineYText
            // 
            this.LineYText.Location = new System.Drawing.Point(584, 52);
            this.LineYText.Margin = new System.Windows.Forms.Padding(2);
            this.LineYText.Name = "LineYText";
            this.LineYText.Size = new System.Drawing.Size(51, 20);
            this.LineYText.TabIndex = 6;
            this.LineYText.Text = "Y";
            // 
            // LineX2
            // 
            this.LineX2.Location = new System.Drawing.Point(584, 117);
            this.LineX2.Margin = new System.Windows.Forms.Padding(2);
            this.LineX2.Name = "LineX2";
            this.LineX2.Size = new System.Drawing.Size(51, 20);
            this.LineX2.TabIndex = 3;
            this.LineX2.Text = "100";
            // 
            // LineY2
            // 
            this.LineY2.Location = new System.Drawing.Point(584, 160);
            this.LineY2.Margin = new System.Windows.Forms.Padding(2);
            this.LineY2.Name = "LineY2";
            this.LineY2.Size = new System.Drawing.Size(51, 20);
            this.LineY2.TabIndex = 4;
            this.LineY2.Text = "50";
            // 
            // LineX2Text
            // 
            this.LineX2Text.Location = new System.Drawing.Point(584, 95);
            this.LineX2Text.Margin = new System.Windows.Forms.Padding(2);
            this.LineX2Text.Name = "LineX2Text";
            this.LineX2Text.Size = new System.Drawing.Size(51, 20);
            this.LineX2Text.TabIndex = 6;
            this.LineX2Text.Text = "X2";
            // 
            // LineY2Text
            // 
            this.LineY2Text.Location = new System.Drawing.Point(584, 138);
            this.LineY2Text.Margin = new System.Windows.Forms.Padding(2);
            this.LineY2Text.Name = "LineY2Text";
            this.LineY2Text.Size = new System.Drawing.Size(51, 20);
            this.LineY2Text.TabIndex = 6;
            this.LineY2Text.Text = "Y2";
            // 
            // lineDrawButton
            // 
            this.lineDrawButton.Location = new System.Drawing.Point(584, 182);
            this.lineDrawButton.Margin = new System.Windows.Forms.Padding(2);
            this.lineDrawButton.Name = "lineDrawButton";
            this.lineDrawButton.Size = new System.Drawing.Size(50, 19);
            this.lineDrawButton.TabIndex = 11;
            this.lineDrawButton.Text = "Draw";
            this.lineDrawButton.UseVisualStyleBackColor = true;
            this.lineDrawButton.Click += new System.EventHandler(this.lineDrawButton_Click);
            // 
            // triangleX
            // 
            this.triangleX.Location = new System.Drawing.Point(638, 31);
            this.triangleX.Margin = new System.Windows.Forms.Padding(2);
            this.triangleX.Name = "triangleX";
            this.triangleX.Size = new System.Drawing.Size(51, 20);
            this.triangleX.TabIndex = 3;
            this.triangleX.Text = "50";
            // 
            // triangleX2
            // 
            this.triangleX2.Location = new System.Drawing.Point(638, 117);
            this.triangleX2.Margin = new System.Windows.Forms.Padding(2);
            this.triangleX2.Name = "triangleX2";
            this.triangleX2.Size = new System.Drawing.Size(51, 20);
            this.triangleX2.TabIndex = 3;
            this.triangleX2.Text = "100";
            // 
            // triangleY
            // 
            this.triangleY.Location = new System.Drawing.Point(638, 74);
            this.triangleY.Margin = new System.Windows.Forms.Padding(2);
            this.triangleY.Name = "triangleY";
            this.triangleY.Size = new System.Drawing.Size(51, 20);
            this.triangleY.TabIndex = 4;
            this.triangleY.Text = "50";
            // 
            // triangleY2
            // 
            this.triangleY2.Location = new System.Drawing.Point(638, 160);
            this.triangleY2.Margin = new System.Windows.Forms.Padding(2);
            this.triangleY2.Name = "triangleY2";
            this.triangleY2.Size = new System.Drawing.Size(51, 20);
            this.triangleY2.TabIndex = 4;
            this.triangleY2.Text = "100";
            // 
            // trianglXText
            // 
            this.trianglXText.Location = new System.Drawing.Point(638, 9);
            this.trianglXText.Margin = new System.Windows.Forms.Padding(2);
            this.trianglXText.Name = "trianglXText";
            this.trianglXText.Size = new System.Drawing.Size(51, 20);
            this.trianglXText.TabIndex = 6;
            this.trianglXText.Text = "X";
            // 
            // trianglX2Text
            // 
            this.trianglX2Text.Location = new System.Drawing.Point(638, 95);
            this.trianglX2Text.Margin = new System.Windows.Forms.Padding(2);
            this.trianglX2Text.Name = "trianglX2Text";
            this.trianglX2Text.Size = new System.Drawing.Size(51, 20);
            this.trianglX2Text.TabIndex = 6;
            this.trianglX2Text.Text = "X2";
            // 
            // trianglYText
            // 
            this.trianglYText.Location = new System.Drawing.Point(638, 52);
            this.trianglYText.Margin = new System.Windows.Forms.Padding(2);
            this.trianglYText.Name = "trianglYText";
            this.trianglYText.Size = new System.Drawing.Size(51, 20);
            this.trianglYText.TabIndex = 6;
            this.trianglYText.Text = "Y";
            // 
            // trianglY2Text
            // 
            this.trianglY2Text.Location = new System.Drawing.Point(638, 138);
            this.trianglY2Text.Margin = new System.Windows.Forms.Padding(2);
            this.trianglY2Text.Name = "trianglY2Text";
            this.trianglY2Text.Size = new System.Drawing.Size(51, 20);
            this.trianglY2Text.TabIndex = 6;
            this.trianglY2Text.Text = "Y2";
            // 
            // TriangleText
            // 
            this.TriangleText.AutoSize = true;
            this.TriangleText.Location = new System.Drawing.Point(644, 292);
            this.TriangleText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TriangleText.Name = "TriangleText";
            this.TriangleText.Size = new System.Drawing.Size(45, 13);
            this.TriangleText.TabIndex = 12;
            this.TriangleText.Text = "Triangle";
            // 
            // TriangleCheck
            // 
            this.TriangleCheck.AutoSize = true;
            this.TriangleCheck.Location = new System.Drawing.Point(652, 310);
            this.TriangleCheck.Margin = new System.Windows.Forms.Padding(2);
            this.TriangleCheck.Name = "TriangleCheck";
            this.TriangleCheck.Size = new System.Drawing.Size(15, 14);
            this.TriangleCheck.TabIndex = 13;
            this.TriangleCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TriangleCheck.UseVisualStyleBackColor = true;
            this.TriangleCheck.CheckedChanged += new System.EventHandler(this.TriangleCheck_CheckedChanged);
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(638, 267);
            this.TriangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(50, 19);
            this.TriangleButton.TabIndex = 14;
            this.TriangleButton.Text = "Draw";
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // triangleX3
            // 
            this.triangleX3.Location = new System.Drawing.Point(638, 203);
            this.triangleX3.Margin = new System.Windows.Forms.Padding(2);
            this.triangleX3.Name = "triangleX3";
            this.triangleX3.Size = new System.Drawing.Size(51, 20);
            this.triangleX3.TabIndex = 3;
            this.triangleX3.Text = "300";
            // 
            // triangleY3
            // 
            this.triangleY3.Location = new System.Drawing.Point(638, 245);
            this.triangleY3.Margin = new System.Windows.Forms.Padding(2);
            this.triangleY3.Name = "triangleY3";
            this.triangleY3.Size = new System.Drawing.Size(51, 20);
            this.triangleY3.TabIndex = 4;
            this.triangleY3.Text = "100";
            // 
            // trianglX3Text
            // 
            this.trianglX3Text.Location = new System.Drawing.Point(638, 181);
            this.trianglX3Text.Margin = new System.Windows.Forms.Padding(2);
            this.trianglX3Text.Name = "trianglX3Text";
            this.trianglX3Text.Size = new System.Drawing.Size(51, 20);
            this.trianglX3Text.TabIndex = 6;
            this.trianglX3Text.Text = "X3";
            // 
            // trianglY3Text
            // 
            this.trianglY3Text.Location = new System.Drawing.Point(638, 224);
            this.trianglY3Text.Margin = new System.Windows.Forms.Padding(2);
            this.trianglY3Text.Name = "trianglY3Text";
            this.trianglY3Text.Size = new System.Drawing.Size(51, 20);
            this.trianglY3Text.TabIndex = 6;
            this.trianglY3Text.Text = "Y3";
            // 
            // rectangleX
            // 
            this.rectangleX.Location = new System.Drawing.Point(693, 31);
            this.rectangleX.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleX.Name = "rectangleX";
            this.rectangleX.Size = new System.Drawing.Size(51, 20);
            this.rectangleX.TabIndex = 3;
            this.rectangleX.Text = "50";
            // 
            // rectangleY
            // 
            this.rectangleY.Location = new System.Drawing.Point(693, 74);
            this.rectangleY.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleY.Name = "rectangleY";
            this.rectangleY.Size = new System.Drawing.Size(51, 20);
            this.rectangleY.TabIndex = 4;
            this.rectangleY.Text = "50";
            // 
            // rectangleXText
            // 
            this.rectangleXText.Location = new System.Drawing.Point(693, 9);
            this.rectangleXText.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleXText.Name = "rectangleXText";
            this.rectangleXText.Size = new System.Drawing.Size(51, 20);
            this.rectangleXText.TabIndex = 6;
            this.rectangleXText.Text = "X";
            // 
            // rectangleYText
            // 
            this.rectangleYText.Location = new System.Drawing.Point(693, 52);
            this.rectangleYText.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleYText.Name = "rectangleYText";
            this.rectangleYText.Size = new System.Drawing.Size(51, 20);
            this.rectangleYText.TabIndex = 6;
            this.rectangleYText.Text = "Y";
            // 
            // rectangleWidth
            // 
            this.rectangleWidth.Location = new System.Drawing.Point(693, 117);
            this.rectangleWidth.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleWidth.Name = "rectangleWidth";
            this.rectangleWidth.Size = new System.Drawing.Size(51, 20);
            this.rectangleWidth.TabIndex = 2;
            this.rectangleWidth.Text = "20";
            // 
            // rectangleWidthText
            // 
            this.rectangleWidthText.Location = new System.Drawing.Point(693, 95);
            this.rectangleWidthText.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleWidthText.Name = "rectangleWidthText";
            this.rectangleWidthText.Size = new System.Drawing.Size(51, 20);
            this.rectangleWidthText.TabIndex = 6;
            this.rectangleWidthText.Text = "Width";
            // 
            // rectangleHeight
            // 
            this.rectangleHeight.Location = new System.Drawing.Point(693, 160);
            this.rectangleHeight.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleHeight.Name = "rectangleHeight";
            this.rectangleHeight.Size = new System.Drawing.Size(51, 20);
            this.rectangleHeight.TabIndex = 2;
            this.rectangleHeight.Text = "20";
            // 
            // rectangleHeightText
            // 
            this.rectangleHeightText.Location = new System.Drawing.Point(693, 138);
            this.rectangleHeightText.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleHeightText.Name = "rectangleHeightText";
            this.rectangleHeightText.Size = new System.Drawing.Size(51, 20);
            this.rectangleHeightText.TabIndex = 6;
            this.rectangleHeightText.Text = "Height";
            // 
            // rectangleCheck
            // 
            this.rectangleCheck.AutoSize = true;
            this.rectangleCheck.Location = new System.Drawing.Point(715, 310);
            this.rectangleCheck.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleCheck.Name = "rectangleCheck";
            this.rectangleCheck.Size = new System.Drawing.Size(15, 14);
            this.rectangleCheck.TabIndex = 15;
            this.rectangleCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rectangleCheck.UseVisualStyleBackColor = true;
            this.rectangleCheck.CheckedChanged += new System.EventHandler(this.rectangleCheck_CheckedChanged);
            // 
            // rectangleText
            // 
            this.rectangleText.AutoSize = true;
            this.rectangleText.Location = new System.Drawing.Point(694, 292);
            this.rectangleText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rectangleText.Name = "rectangleText";
            this.rectangleText.Size = new System.Drawing.Size(56, 13);
            this.rectangleText.TabIndex = 16;
            this.rectangleText.Text = "Rectangle";
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(693, 182);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(50, 19);
            this.rectangleButton.TabIndex = 17;
            this.rectangleButton.Text = "Draw";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(529, 357);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 19);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PenWidth
            // 
            this.PenWidth.Location = new System.Drawing.Point(652, 357);
            this.PenWidth.Margin = new System.Windows.Forms.Padding(2);
            this.PenWidth.Name = "PenWidth";
            this.PenWidth.Size = new System.Drawing.Size(76, 20);
            this.PenWidth.TabIndex = 19;
            this.PenWidth.Text = "5";
            // 
            // PenWidthText
            // 
            this.PenWidthText.AutoSize = true;
            this.PenWidthText.Location = new System.Drawing.Point(652, 338);
            this.PenWidthText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PenWidthText.Name = "PenWidthText";
            this.PenWidthText.Size = new System.Drawing.Size(54, 13);
            this.PenWidthText.TabIndex = 20;
            this.PenWidthText.Text = "Pen width";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(529, 380);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(56, 19);
            this.LoadButton.TabIndex = 18;
            this.LoadButton.Text = "load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // colorBut
            // 
            this.colorBut.Location = new System.Drawing.Point(652, 380);
            this.colorBut.Margin = new System.Windows.Forms.Padding(2);
            this.colorBut.Name = "colorBut";
            this.colorBut.Size = new System.Drawing.Size(19, 19);
            this.colorBut.TabIndex = 21;
            this.colorBut.UseVisualStyleBackColor = true;
            this.colorBut.Click += new System.EventHandler(this.colorBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 438);
            this.Controls.Add(this.colorBut);
            this.Controls.Add(this.PenWidthText);
            this.Controls.Add(this.PenWidth);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.rectangleText);
            this.Controls.Add(this.rectangleCheck);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.TriangleCheck);
            this.Controls.Add(this.TriangleText);
            this.Controls.Add(this.lineDrawButton);
            this.Controls.Add(this.LineLabel);
            this.Controls.Add(this.LineCheck);
            this.Controls.Add(this.CircleCheck);
            this.Controls.Add(this.CircleText);
            this.Controls.Add(this.trianglY3Text);
            this.Controls.Add(this.trianglY2Text);
            this.Controls.Add(this.LineY2Text);
            this.Controls.Add(this.rectangleYText);
            this.Controls.Add(this.trianglYText);
            this.Controls.Add(this.LineYText);
            this.Controls.Add(this.y_Text);
            this.Controls.Add(this.trianglX3Text);
            this.Controls.Add(this.trianglX2Text);
            this.Controls.Add(this.LineX2Text);
            this.Controls.Add(this.triangleY3);
            this.Controls.Add(this.rectangleXText);
            this.Controls.Add(this.trianglXText);
            this.Controls.Add(this.triangleY2);
            this.Controls.Add(this.LineXText);
            this.Controls.Add(this.rectangleY);
            this.Controls.Add(this.LineY2);
            this.Controls.Add(this.triangleY);
            this.Controls.Add(this.triangleX3);
            this.Controls.Add(this.XCircle);
            this.Controls.Add(this.triangleX2);
            this.Controls.Add(this.LineY);
            this.Controls.Add(this.rectangleX);
            this.Controls.Add(this.LineX2);
            this.Controls.Add(this.triangleX);
            this.Controls.Add(this.rectangleHeightText);
            this.Controls.Add(this.rectangleWidthText);
            this.Controls.Add(this.circleR);
            this.Controls.Add(this.LineX);
            this.Controls.Add(this.rectangleHeight);
            this.Controls.Add(this.circleY);
            this.Controls.Add(this.rectangleWidth);
            this.Controls.Add(this.circleX);
            this.Controls.Add(this.circleRadius);
            this.Controls.Add(this.board);
            this.Controls.Add(this.circleButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.TextBox circleRadius;
        private System.Windows.Forms.TextBox circleX;
        private System.Windows.Forms.TextBox circleY;
        private System.Windows.Forms.TextBox circleR;
        private System.Windows.Forms.TextBox XCircle;
        private System.Windows.Forms.TextBox y_Text;
        private System.Windows.Forms.Label CircleText;
        private System.Windows.Forms.CheckBox CircleCheck;
        private System.Windows.Forms.CheckBox LineCheck;
        private System.Windows.Forms.Label LineLabel;
        private System.Windows.Forms.TextBox LineX;
        private System.Windows.Forms.TextBox LineY;
        private System.Windows.Forms.TextBox LineXText;
        private System.Windows.Forms.TextBox LineYText;
        private System.Windows.Forms.TextBox LineX2;
        private System.Windows.Forms.TextBox LineY2;
        private System.Windows.Forms.TextBox LineX2Text;
        private System.Windows.Forms.TextBox LineY2Text;
        private System.Windows.Forms.Button lineDrawButton;
        private System.Windows.Forms.TextBox triangleX;
        private System.Windows.Forms.TextBox triangleX2;
        private System.Windows.Forms.TextBox triangleY;
        private System.Windows.Forms.TextBox triangleY2;
        private System.Windows.Forms.TextBox trianglXText;
        private System.Windows.Forms.TextBox trianglX2Text;
        private System.Windows.Forms.TextBox trianglYText;
        private System.Windows.Forms.TextBox trianglY2Text;
        private System.Windows.Forms.Label TriangleText;
        private System.Windows.Forms.CheckBox TriangleCheck;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.TextBox triangleX3;
        private System.Windows.Forms.TextBox triangleY3;
        private System.Windows.Forms.TextBox trianglX3Text;
        private System.Windows.Forms.TextBox trianglY3Text;
        private System.Windows.Forms.TextBox rectangleX;
        private System.Windows.Forms.TextBox rectangleY;
        private System.Windows.Forms.TextBox rectangleXText;
        private System.Windows.Forms.TextBox rectangleYText;
        private System.Windows.Forms.TextBox rectangleWidth;
        private System.Windows.Forms.TextBox rectangleWidthText;
        private System.Windows.Forms.TextBox rectangleHeight;
        private System.Windows.Forms.TextBox rectangleHeightText;
        private System.Windows.Forms.CheckBox rectangleCheck;
        private System.Windows.Forms.Label rectangleText;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox PenWidth;
        private System.Windows.Forms.Label PenWidthText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button colorBut;
    }
}

