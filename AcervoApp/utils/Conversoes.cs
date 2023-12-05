using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcervoApp.utils
{
    public static class Conversoes
    {

        public static void salvarPdf(byte[] conteudo)
        {
        }

        public static Image BytesToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes);
            Image imagem = Image.FromStream(ms);
            return imagem;
        }

        public static byte[] ImageToBytes(Image img)
        {

            try
            {

                using (MemoryStream mStream = new MemoryStream())
                {
                    img.Save(mStream, img.RawFormat);
                    return mStream.ToArray();
                }

            } catch (Exception e)
            {
                return null;
            }
            

        }

        public static PdfDocument BytesToPdf(byte[] document)
        {

            var stream = new MemoryStream(document);
            return PdfDocument.Load(stream);

        }

    }
}
