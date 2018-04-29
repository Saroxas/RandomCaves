namespace RandomCaves
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.richTextBoxMap = new System.Windows.Forms.RichTextBox();
            this.buttonGenerateNewMap = new System.Windows.Forms.Button();
            this.labelXLength = new System.Windows.Forms.Label();
            this.numericUpDownXLength = new System.Windows.Forms.NumericUpDown();
            this.labelYLength = new System.Windows.Forms.Label();
            this.numericUpDownYLength = new System.Windows.Forms.NumericUpDown();
            this.labelWallChance = new System.Windows.Forms.Label();
            this.numericUpDownWallChance = new System.Windows.Forms.NumericUpDown();
            this.buttonIterateMap = new System.Windows.Forms.Button();
            this.labelMinIteration = new System.Windows.Forms.Label();
            this.numericUpDownMinIteration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumWallsWhenWall = new System.Windows.Forms.NumericUpDown();
            this.labelNumWallsWhenWall = new System.Windows.Forms.Label();
            this.numericUpDownNumWallsWhenEmpty = new System.Windows.Forms.NumericUpDown();
            this.labelNumWallsWhenEmpty = new System.Windows.Forms.Label();
            this.labelAmountOfIterations = new System.Windows.Forms.Label();
            this.numericUpDownAmountOfIterations = new System.Windows.Forms.NumericUpDown();
            this.labelIterationCount = new System.Windows.Forms.Label();
            this.buttonFrameWalls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWallChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumWallsWhenWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumWallsWhenEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountOfIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxMap
            // 
            resources.ApplyResources(this.richTextBoxMap, "richTextBoxMap");
            this.richTextBoxMap.Name = "richTextBoxMap";
            this.richTextBoxMap.ReadOnly = true;
            // 
            // buttonGenerateNewMap
            // 
            resources.ApplyResources(this.buttonGenerateNewMap, "buttonGenerateNewMap");
            this.buttonGenerateNewMap.Name = "buttonGenerateNewMap";
            this.buttonGenerateNewMap.UseVisualStyleBackColor = true;
            this.buttonGenerateNewMap.Click += new System.EventHandler(this.buttonGenerateNewMap_Click);
            // 
            // labelXLength
            // 
            resources.ApplyResources(this.labelXLength, "labelXLength");
            this.labelXLength.Name = "labelXLength";
            // 
            // numericUpDownXLength
            // 
            resources.ApplyResources(this.numericUpDownXLength, "numericUpDownXLength");
            this.numericUpDownXLength.Name = "numericUpDownXLength";
            this.numericUpDownXLength.ValueChanged += new System.EventHandler(this.numericUpDownXLength_ValueChanged);
            // 
            // labelYLength
            // 
            resources.ApplyResources(this.labelYLength, "labelYLength");
            this.labelYLength.Name = "labelYLength";
            // 
            // numericUpDownYLength
            // 
            resources.ApplyResources(this.numericUpDownYLength, "numericUpDownYLength");
            this.numericUpDownYLength.Name = "numericUpDownYLength";
            this.numericUpDownYLength.ValueChanged += new System.EventHandler(this.numericUpDownYLength_ValueChanged);
            // 
            // labelWallChance
            // 
            resources.ApplyResources(this.labelWallChance, "labelWallChance");
            this.labelWallChance.Name = "labelWallChance";
            // 
            // numericUpDownWallChance
            // 
            resources.ApplyResources(this.numericUpDownWallChance, "numericUpDownWallChance");
            this.numericUpDownWallChance.Name = "numericUpDownWallChance";
            this.numericUpDownWallChance.ValueChanged += new System.EventHandler(this.numericUpDownWallChance_ValueChanged);
            // 
            // buttonIterateMap
            // 
            resources.ApplyResources(this.buttonIterateMap, "buttonIterateMap");
            this.buttonIterateMap.Name = "buttonIterateMap";
            this.buttonIterateMap.UseVisualStyleBackColor = true;
            this.buttonIterateMap.Click += new System.EventHandler(this.buttonIterateMap_Click);
            // 
            // labelMinIteration
            // 
            resources.ApplyResources(this.labelMinIteration, "labelMinIteration");
            this.labelMinIteration.Name = "labelMinIteration";
            // 
            // numericUpDownMinIteration
            // 
            resources.ApplyResources(this.numericUpDownMinIteration, "numericUpDownMinIteration");
            this.numericUpDownMinIteration.Name = "numericUpDownMinIteration";
            this.numericUpDownMinIteration.ValueChanged += new System.EventHandler(this.numericUpDownMinIteration_ValueChanged);
            // 
            // numericUpDownNumWallsWhenWall
            // 
            resources.ApplyResources(this.numericUpDownNumWallsWhenWall, "numericUpDownNumWallsWhenWall");
            this.numericUpDownNumWallsWhenWall.Name = "numericUpDownNumWallsWhenWall";
            this.numericUpDownNumWallsWhenWall.ValueChanged += new System.EventHandler(this.numericUpDownNumWallsWhenWall_ValueChanged);
            // 
            // labelNumWallsWhenWall
            // 
            resources.ApplyResources(this.labelNumWallsWhenWall, "labelNumWallsWhenWall");
            this.labelNumWallsWhenWall.Name = "labelNumWallsWhenWall";
            // 
            // numericUpDownNumWallsWhenEmpty
            // 
            resources.ApplyResources(this.numericUpDownNumWallsWhenEmpty, "numericUpDownNumWallsWhenEmpty");
            this.numericUpDownNumWallsWhenEmpty.Name = "numericUpDownNumWallsWhenEmpty";
            this.numericUpDownNumWallsWhenEmpty.ValueChanged += new System.EventHandler(this.numericUpDownNumWallsWhenEmpty_ValueChanged);
            // 
            // labelNumWallsWhenEmpty
            // 
            resources.ApplyResources(this.labelNumWallsWhenEmpty, "labelNumWallsWhenEmpty");
            this.labelNumWallsWhenEmpty.Name = "labelNumWallsWhenEmpty";
            // 
            // labelAmountOfIterations
            // 
            resources.ApplyResources(this.labelAmountOfIterations, "labelAmountOfIterations");
            this.labelAmountOfIterations.Name = "labelAmountOfIterations";
            // 
            // numericUpDownAmountOfIterations
            // 
            resources.ApplyResources(this.numericUpDownAmountOfIterations, "numericUpDownAmountOfIterations");
            this.numericUpDownAmountOfIterations.Name = "numericUpDownAmountOfIterations";
            this.numericUpDownAmountOfIterations.ValueChanged += new System.EventHandler(this.numericUpDownAmountOfIterations_ValueChanged);
            // 
            // labelIterationCount
            // 
            resources.ApplyResources(this.labelIterationCount, "labelIterationCount");
            this.labelIterationCount.Name = "labelIterationCount";
            // 
            // buttonFrameWalls
            // 
            resources.ApplyResources(this.buttonFrameWalls, "buttonFrameWalls");
            this.buttonFrameWalls.Name = "buttonFrameWalls";
            this.buttonFrameWalls.UseVisualStyleBackColor = true;
            this.buttonFrameWalls.Click += new System.EventHandler(this.buttonFrameWalls_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFrameWalls);
            this.Controls.Add(this.labelIterationCount);
            this.Controls.Add(this.numericUpDownAmountOfIterations);
            this.Controls.Add(this.labelAmountOfIterations);
            this.Controls.Add(this.numericUpDownNumWallsWhenEmpty);
            this.Controls.Add(this.labelNumWallsWhenEmpty);
            this.Controls.Add(this.numericUpDownNumWallsWhenWall);
            this.Controls.Add(this.labelNumWallsWhenWall);
            this.Controls.Add(this.numericUpDownMinIteration);
            this.Controls.Add(this.labelMinIteration);
            this.Controls.Add(this.buttonIterateMap);
            this.Controls.Add(this.numericUpDownWallChance);
            this.Controls.Add(this.labelWallChance);
            this.Controls.Add(this.numericUpDownYLength);
            this.Controls.Add(this.labelYLength);
            this.Controls.Add(this.numericUpDownXLength);
            this.Controls.Add(this.labelXLength);
            this.Controls.Add(this.buttonGenerateNewMap);
            this.Controls.Add(this.richTextBoxMap);
            this.Name = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWallChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumWallsWhenWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumWallsWhenEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountOfIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMap;
        private System.Windows.Forms.Button buttonGenerateNewMap;
        private System.Windows.Forms.Label labelXLength;
        private System.Windows.Forms.NumericUpDown numericUpDownXLength;
        private System.Windows.Forms.Label labelYLength;
        private System.Windows.Forms.NumericUpDown numericUpDownYLength;
        private System.Windows.Forms.Label labelWallChance;
        private System.Windows.Forms.NumericUpDown numericUpDownWallChance;
        private System.Windows.Forms.Button buttonIterateMap;
        private System.Windows.Forms.Label labelMinIteration;
        private System.Windows.Forms.NumericUpDown numericUpDownMinIteration;
        private System.Windows.Forms.NumericUpDown numericUpDownNumWallsWhenWall;
        private System.Windows.Forms.Label labelNumWallsWhenWall;
        private System.Windows.Forms.NumericUpDown numericUpDownNumWallsWhenEmpty;
        private System.Windows.Forms.Label labelNumWallsWhenEmpty;
        private System.Windows.Forms.Label labelAmountOfIterations;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountOfIterations;
        private System.Windows.Forms.Label labelIterationCount;
        private System.Windows.Forms.Button buttonFrameWalls;
    }
}

