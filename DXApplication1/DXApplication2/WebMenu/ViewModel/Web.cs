using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WebMenu.ViewModel
{
    class Web
    {
        public string FotoName { get; set; }

        public string Foto { get; set; }


        static public void AddNewPage(String[] name, int count=0)
        {
            string path = @"G:\web\index.html";
            string text = @"<head>
                                <title> It Helps you</title >
                            </head> 
                            <body class=" + '\u0022' + "body" + '\u0022' + @" >"+
                               @"< div class=" + '\u0022' + "hovergallery" + '\u0022' +@" >";

            if (!File.Exists(path)) File.Create(path);
            StreamWriter output = new StreamWriter(path);

            output.WriteLine(text);
            
            for (int i = 0; i < (name.Length < 100 ? name.Length : 100); i++){
                try
                {   
                    File.Copy(name[i].ToString(), @"G:\web\photo\img" + i.ToString() + ".jpg", true);
                    output.WriteLine(@"<img src = " + '\u0022' + @"G:\web\photo\img" + i.ToString() + ".jpg" + '\u0022' + @" />");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }


            output.WriteLine(@"</div>
                             </body>
                            </html>
                                <style type = " + '\u0022' +@"text/css" + '\u0022' + @" >
                                    .body{
                                        background-color:#c0c0c0;
                                    }
                                    .hovergallery img{
                                                    -webkit-transform:scale(0.2); /*Webkit: уменьшаем размер до 0.8*/
                                                    -moz-transform:scale(0.2); /*Mozilla: масштабирование*/
                                                    -o-transform:scale(0.2); /*Opera: масштабирование*/
                                                    -webkit-transition-duration: 0.5s; /*Webkit: длительность анимации*/
                                                    -moz-transition-duration: 0.5s; /*Mozilla: длительность анимации*/
                                                    -o-transition-duration: 0.5s; /*Opera: длительность анимации*/
                                                    opacity: 0.7; /*Начальная прозрачность изображений*/
                                                    margin: 0 10px 5px 0; /*Интервалы между изображениями*/
                                                    }
            
                                    .hovergallery img: hover{
                                                    -webkit-transform:scale(1.1); /*Webkit: увеличиваем размер до 1.2x*/
                                                    -moz-transform:scale(1.1); /*Mozilla: масштабирование*/
                                                    -o-transform:scale(1.1); /*Opera: масштабирование*/
                                                    box-shadow:0px 0px 30px gray; /*CSS3 тени: 30px размытая тень вокруг всего изображения*/
                                                    -webkit-box-shadow:0px 0px 30px gray; /*Webkit: тени*/
                                                    -moz-box-shadow:0px 0px 30px gray; /*Mozilla: тени*/
                                                     opacity: 1;
                                                    }
                                </style >");

            output.Close();
        }

        //public Image ResizeOrigImg(Image image, int nWidth, int nHeight)
        //{
        //    int newWidth, newHeight;
        //    var coefH = (double)nHeight / (double)image.Height;
        //    var coefW = (double)nWidth / (double)image.Width;
        //    if (coefW >= coefH)
        //    {
        //        newHeight = (int)(image.Height * coefH);
        //        newWidth = (int)(image.Width * coefH);
        //    }
        //    else
        //    {
        //        newHeight = (int)(image.Height * coefW);
        //        newWidth = (int)(image.Width * coefW);
        //    }

        //    Image result = new Bitmap(newWidth, newHeight);
        //    using (var g = Graphics.FromImage(result))
        //    {
        //        g.CompositingQuality = CompositingQuality.HighQuality;
        //        g.SmoothingMode = SmoothingMode.HighQuality;
        //        g.InterpolationMode = InterpolationMode.HighQualityBicubic;

        //        g.DrawImage(image, 0, 0, newWidth, newHeight);
        //        g.Dispose();
        //    }
        //    return result;
        //}


    

    }




  
}
