﻿using System.ComponentModel;

using KeLi.GameFactory.UI;

namespace KeLi.MengSang.Parts
{
    public partial class ArmSuitControl : ShadowControl
    {
        public ArmSuitControl()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string SuitName
        {
            get => lblSuitName.Text;
            set => lblSuitName.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string SingleArm
        {
            get => lblSingleArm.Text;
            set => lblSingleArm.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string DoubleArm
        {
            get => lblDoubleArm.Text;
            set => lblDoubleArm.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string SpearArm
        {
            get => lblSpearArm.Text;
            set => lblSpearArm.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string BowArm
        {
            get => lblBowArm.Text;
            set => lblBowArm.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string ClawArm
        {
            get => lblClawArm.Text;
            set => lblClawArm.Text = value;
        }
    }
}