using System;
namespace CypherhillCalcLibary.Functions
{
    public class TextToChiper
    {
        public string TextToChiperText(string text)
        {
            // Instancing a few variable.
            int i, j, sum = 0, end = 0;
            int[,] mtrx = new int[25, 25];
            int[,] ans = new int[25, 1];
            string chiperText = "";

            // Creating an char array of inputed text
            char[] txt = text.ToCharArray();
            end = txt.Length;


            for (i = 0; i < end; i++)
            {
                txt[i] = Convert.ToChar(txt[i] - 'a');
            }

            Random rnd = new Random();
            for (i = 0; i < end; i++)
            {
                for (j = 0; j < end; j++)
                {

                    mtrx[i, j] = rnd.Next();
                }

            }

            for (i = 0; i < end; i++)
            {

                sum = 0;
                for (j = 0; j < end; j++)
                {
                    sum += mtrx[i, j] * (int)txt[j];
                }
                ans[i, 0] = sum;
            }

            for (i = 0; i < end; i++)
            {
                char cipher = (char)(((ans[i, 0]) % 26) + 97);
                chiperText = cipher.ToString();
            }

            return chiperText;
        }
    }
}
