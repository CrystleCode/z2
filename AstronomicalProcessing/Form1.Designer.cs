namespace AstronomicalProcessing
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchHourData = new System.Windows.Forms.TextBox();
            this.grpHoldList = new System.Windows.Forms.GroupBox();
            this.lbxHourData = new System.Windows.Forms.ListBox();
            this.btnHourData = new System.Windows.Forms.Button();
            this.txtInputHourData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.btnPrintAllData = new System.Windows.Forms.Button();
            this.btnClearAllData = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnInsertRandomData = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMidCalculate = new System.Windows.Forms.Button();
            this.btnModeCalculate = new System.Windows.Forms.Button();
            this.btnAverageCalculate = new System.Windows.Forms.Button();
            this.btnRangeCalculate = new System.Windows.Forms.Button();
            this.lbxCalculations = new System.Windows.Forms.ListBox();
            this.btnSequentialSearch = new System.Windows.Forms.Button();
            this.lbxSequentialResults = new System.Windows.Forms.ListBox();
            this.txtSequentialData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpHoldList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search hour";
            // 
            // txtSearchHourData
            // 
            this.txtSearchHourData.Location = new System.Drawing.Point(269, 108);
            this.txtSearchHourData.Name = "txtSearchHourData";
            this.txtSearchHourData.Size = new System.Drawing.Size(100, 20);
            this.txtSearchHourData.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtSearchHourData, "Enter hour to search for.");
            // 
            // grpHoldList
            // 
            this.grpHoldList.Controls.Add(this.lbxHourData);
            this.grpHoldList.Location = new System.Drawing.Point(13, 13);
            this.grpHoldList.Name = "grpHoldList";
            this.grpHoldList.Size = new System.Drawing.Size(163, 425);
            this.grpHoldList.TabIndex = 2;
            this.grpHoldList.TabStop = false;
            this.grpHoldList.Text = "Hour Data";
            // 
            // lbxHourData
            // 
            this.lbxHourData.FormattingEnabled = true;
            this.lbxHourData.Location = new System.Drawing.Point(6, 19);
            this.lbxHourData.Name = "lbxHourData";
            this.lbxHourData.Size = new System.Drawing.Size(151, 394);
            this.lbxHourData.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lbxHourData, "Displays array of values.");
            // 
            // btnHourData
            // 
            this.btnHourData.Location = new System.Drawing.Point(185, 134);
            this.btnHourData.Name = "btnHourData";
            this.btnHourData.Size = new System.Drawing.Size(184, 27);
            this.btnHourData.TabIndex = 3;
            this.btnHourData.Text = "Show Single Hour Data";
            this.toolTip1.SetToolTip(this.btnHourData, "Print specified hour to Hour Data.");
            this.btnHourData.UseVisualStyleBackColor = true;
            this.btnHourData.Click += new System.EventHandler(this.btnHourData_Click);
            // 
            // txtInputHourData
            // 
            this.txtInputHourData.Location = new System.Drawing.Point(269, 20);
            this.txtInputHourData.Name = "txtInputHourData";
            this.txtInputHourData.Size = new System.Drawing.Size(100, 20);
            this.txtInputHourData.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtInputHourData, "Input hour to change value at that hour.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Hour";
            // 
            // txtEditData
            // 
            this.txtEditData.Location = new System.Drawing.Point(269, 46);
            this.txtEditData.Name = "txtEditData";
            this.txtEditData.Size = new System.Drawing.Size(100, 20);
            this.txtEditData.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtEditData, "Input new value to be held at designated hour.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add / Edit Data";
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(185, 72);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(184, 27);
            this.btnUpdateData.TabIndex = 8;
            this.btnUpdateData.Text = "Add / Edit Data";
            this.toolTip1.SetToolTip(this.btnUpdateData, "Change the value at any hour.");
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // btnPrintAllData
            // 
            this.btnPrintAllData.Location = new System.Drawing.Point(185, 312);
            this.btnPrintAllData.Name = "btnPrintAllData";
            this.btnPrintAllData.Size = new System.Drawing.Size(184, 27);
            this.btnPrintAllData.TabIndex = 9;
            this.btnPrintAllData.Text = "Print All Data";
            this.toolTip1.SetToolTip(this.btnPrintAllData, "Prints the previous data held in Hour Data.");
            this.btnPrintAllData.UseVisualStyleBackColor = true;
            this.btnPrintAllData.Click += new System.EventHandler(this.btnPrintAllData_Click);
            // 
            // btnClearAllData
            // 
            this.btnClearAllData.Location = new System.Drawing.Point(185, 345);
            this.btnClearAllData.Name = "btnClearAllData";
            this.btnClearAllData.Size = new System.Drawing.Size(184, 27);
            this.btnClearAllData.TabIndex = 10;
            this.btnClearAllData.Text = "Clear All Data";
            this.toolTip1.SetToolTip(this.btnClearAllData, "Empties Hour Data and Calculations of any data.");
            this.btnClearAllData.UseVisualStyleBackColor = true;
            this.btnClearAllData.Click += new System.EventHandler(this.btnClearAllData_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(185, 378);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(184, 27);
            this.btnBubbleSort.TabIndex = 11;
            this.btnBubbleSort.Text = "Bubble Sort Hour Data";
            this.toolTip1.SetToolTip(this.btnBubbleSort, "Sorts values into numerical order.");
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnInsertRandomData
            // 
            this.btnInsertRandomData.Location = new System.Drawing.Point(185, 411);
            this.btnInsertRandomData.Name = "btnInsertRandomData";
            this.btnInsertRandomData.Size = new System.Drawing.Size(184, 27);
            this.btnInsertRandomData.TabIndex = 12;
            this.btnInsertRandomData.Text = "Insert Random Data";
            this.toolTip1.SetToolTip(this.btnInsertRandomData, "Generates random array of values in Hour Data.");
            this.btnInsertRandomData.UseVisualStyleBackColor = true;
            this.btnInsertRandomData.Click += new System.EventHandler(this.btnInsertRandomData_Click);
            // 
            // btnMidCalculate
            // 
            this.btnMidCalculate.Location = new System.Drawing.Point(427, 16);
            this.btnMidCalculate.Name = "btnMidCalculate";
            this.btnMidCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnMidCalculate.TabIndex = 13;
            this.btnMidCalculate.Text = "Mid-Extreme";
            this.toolTip1.SetToolTip(this.btnMidCalculate, "Calculate the mid-extreme of all values recorded.");
            this.btnMidCalculate.UseVisualStyleBackColor = true;
            this.btnMidCalculate.Click += new System.EventHandler(this.btnMidCalculate_Click);
            // 
            // btnModeCalculate
            // 
            this.btnModeCalculate.Location = new System.Drawing.Point(427, 46);
            this.btnModeCalculate.Name = "btnModeCalculate";
            this.btnModeCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnModeCalculate.TabIndex = 14;
            this.btnModeCalculate.Text = "Mode";
            this.toolTip1.SetToolTip(this.btnModeCalculate, "Calculate the most common value recorded.");
            this.btnModeCalculate.UseVisualStyleBackColor = true;
            this.btnModeCalculate.Click += new System.EventHandler(this.btnModeCalculate_Click);
            // 
            // btnAverageCalculate
            // 
            this.btnAverageCalculate.Location = new System.Drawing.Point(427, 74);
            this.btnAverageCalculate.Name = "btnAverageCalculate";
            this.btnAverageCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnAverageCalculate.TabIndex = 15;
            this.btnAverageCalculate.Text = "Average";
            this.toolTip1.SetToolTip(this.btnAverageCalculate, "Calculate the average of all values recorded.");
            this.btnAverageCalculate.UseVisualStyleBackColor = true;
            this.btnAverageCalculate.Click += new System.EventHandler(this.btnAverageCalculate_Click);
            // 
            // btnRangeCalculate
            // 
            this.btnRangeCalculate.Location = new System.Drawing.Point(427, 104);
            this.btnRangeCalculate.Name = "btnRangeCalculate";
            this.btnRangeCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnRangeCalculate.TabIndex = 16;
            this.btnRangeCalculate.Text = "Range";
            this.toolTip1.SetToolTip(this.btnRangeCalculate, "Calculate the range between the largest and smallest values.");
            this.btnRangeCalculate.UseVisualStyleBackColor = true;
            this.btnRangeCalculate.Click += new System.EventHandler(this.btnRangeCalculate_Click);
            // 
            // lbxCalculations
            // 
            this.lbxCalculations.FormattingEnabled = true;
            this.lbxCalculations.Location = new System.Drawing.Point(520, 16);
            this.lbxCalculations.Name = "lbxCalculations";
            this.lbxCalculations.Size = new System.Drawing.Size(268, 108);
            this.lbxCalculations.TabIndex = 17;
            this.toolTip1.SetToolTip(this.lbxCalculations, "Displays calculations of mid, mode, average and range.");
            // 
            // btnSequentialSearch
            // 
            this.btnSequentialSearch.Location = new System.Drawing.Point(185, 206);
            this.btnSequentialSearch.Name = "btnSequentialSearch";
            this.btnSequentialSearch.Size = new System.Drawing.Size(104, 23);
            this.btnSequentialSearch.TabIndex = 18;
            this.btnSequentialSearch.Text = "Sequential Search";
            this.btnSequentialSearch.UseVisualStyleBackColor = true;
            this.btnSequentialSearch.Click += new System.EventHandler(this.btnSequentialSearch_Click);
            // 
            // lbxSequentialResults
            // 
            this.lbxSequentialResults.FormattingEnabled = true;
            this.lbxSequentialResults.Location = new System.Drawing.Point(185, 235);
            this.lbxSequentialResults.Name = "lbxSequentialResults";
            this.lbxSequentialResults.Size = new System.Drawing.Size(184, 69);
            this.lbxSequentialResults.TabIndex = 19;
            // 
            // txtSequentialData
            // 
            this.txtSequentialData.Location = new System.Drawing.Point(185, 180);
            this.txtSequentialData.Name = "txtSequentialData";
            this.txtSequentialData.Size = new System.Drawing.Size(100, 20);
            this.txtSequentialData.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Search Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSequentialData);
            this.Controls.Add(this.lbxSequentialResults);
            this.Controls.Add(this.btnSequentialSearch);
            this.Controls.Add(this.lbxCalculations);
            this.Controls.Add(this.btnRangeCalculate);
            this.Controls.Add(this.btnAverageCalculate);
            this.Controls.Add(this.btnModeCalculate);
            this.Controls.Add(this.btnMidCalculate);
            this.Controls.Add(this.btnInsertRandomData);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnClearAllData);
            this.Controls.Add(this.btnPrintAllData);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.txtEditData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInputHourData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHourData);
            this.Controls.Add(this.grpHoldList);
            this.Controls.Add(this.txtSearchHourData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpHoldList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchHourData;
        private System.Windows.Forms.GroupBox grpHoldList;
        private System.Windows.Forms.ListBox lbxHourData;
        private System.Windows.Forms.Button btnHourData;
        private System.Windows.Forms.TextBox txtInputHourData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Button btnPrintAllData;
        private System.Windows.Forms.Button btnClearAllData;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnInsertRandomData;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMidCalculate;
        private System.Windows.Forms.Button btnModeCalculate;
        private System.Windows.Forms.Button btnAverageCalculate;
        private System.Windows.Forms.Button btnRangeCalculate;
        private System.Windows.Forms.ListBox lbxCalculations;
        private System.Windows.Forms.Button btnSequentialSearch;
        private System.Windows.Forms.ListBox lbxSequentialResults;
        private System.Windows.Forms.TextBox txtSequentialData;
        private System.Windows.Forms.Label label4;
    }
}

