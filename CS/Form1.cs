using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace SplashScreenManagerSample01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            LongInitialization();
        }
        protected void LongInitialization() {
            BaseInitialization();
            LoadFonts();
            LoadTextures();
        }
        
        void BaseInitialization() {
            // Set progress stage to be displayed by SplashImagePainter
            SplashImagePainter.Painter.ViewInfo.Stage = "Initialization";
            for(int i = 1; i <= 100; i++) {
                System.Threading.Thread.Sleep(20);
                
                // Change progress to be displayed by SplashImagePainter
                SplashImagePainter.Painter.ViewInfo.Counter = i;
                //Force SplashImagePainter to repaint information
                SplashScreenManager.Default.Invalidate();
            }
        }
        void LoadFonts() {
            // Set progress stage to be displayed by SplashImagePainter
            SplashImagePainter.Painter.ViewInfo.Stage = "Loading Fonts";
            for(int i = 1; i <= 100; i++) {
                System.Threading.Thread.Sleep(20);

                // Change progress to be displayed by SplashImagePainter
                SplashImagePainter.Painter.ViewInfo.Counter = i;
                //Force SplashImagePainter to repaint information
                SplashScreenManager.Default.Invalidate();
            }
        }
        void LoadTextures() {
            // Set progress stage to be displayed by SplashImagePainter
            SplashImagePainter.Painter.ViewInfo.Stage = "Loading Textures";
            for(int i = 1; i <= 100; i++) {
                System.Threading.Thread.Sleep(20);

                // Change progress to be displayed by SplashImagePainter
                SplashImagePainter.Painter.ViewInfo.Counter = i;
                //Force SplashImagePainter to repaint information
                SplashScreenManager.Default.Invalidate();
            }
        }
        //
        
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            // Close splash image
            SplashScreenManager.HideImage();
        }
    }
}
