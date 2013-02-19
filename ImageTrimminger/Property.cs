using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageTrimminger
{
    /// <summary>
    /// プロパティクラス．
    /// </summary>
    class Property
    {
        private string[] list = new string[] {".jpg", ".jpeg", ".jpe", ".gif",
                                              ".bmp", ".png", ".tif", ".tiff"};
        /// <summary>
        /// 画像の拡張子のリストを返すプロパティ関数．
        /// </summary>
        public string[] SearchExtension {
            get { return this.list; }
        }
    }
}
