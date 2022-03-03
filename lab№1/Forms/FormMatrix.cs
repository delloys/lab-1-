using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1.Forms
{
    public partial class FormMatrix : Form
    {
        //int[,] arr = new int[,] { {1,1,4,0,5},
        //                              {2,1,9,1,6},
        //                              {3,1,2,0,3},
        //                              {4,1,1,0,3},
        //                              {7,1,9,0,3} };


        int[,] arrNew = new int[5, 5];
        int[] setSum = new int[5];

        public FormMatrix()
        {

            InitializeComponent();            

        }


        private void RandMatrix(int[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = random.Next(10);
                }
            }
        }

        private void FormMatrix_Load(object sender, EventArgs e)
        {
            label3.Text = "";            
        }

        static void MatrixReplace(int[,] arr)
        {
            //сам цикл
            for (int n = 0; n < arr.GetLength(1); n++)
            {
                for (int j = 1; j < arr.GetLength(1); j++) //проходимся по столбцам, начинаем с первого
                {
                    int sumPrevColumn = 0; // сумма предыдущего столбца
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        sumPrevColumn += arr[i, j - 1];
                    }

                    int sumCurrentColumn = 0;       // сумма текущего столбца
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        sumCurrentColumn += arr[i, j];                        
                    }                                    

                    if (sumPrevColumn > sumCurrentColumn) //если сумма предыдущего столбца больше чем текущего, то меняем местами столбцы
                    {
                        for (int k = 0; k < arr.GetLength(0); k++)
                        {
                            int temp = arr[k, j];
                            arr[k, j] = arr[k, j - 1];
                            arr[k, j - 1] = temp;
                        }
                    }
                }
            }           
        }

        private void GetColumnSum(int[,] arr,int[] sum)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int firstSum = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    firstSum = firstSum + arr[j, i];
                }
                sum[i] = firstSum;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandMatrix(arrNew);
            GetColumnSum(arrNew, setSum);

            label3.Text = "";
            for (int i = 0; i < arrNew.GetLength(0); i++)
            {
                for (int j = 0; j < arrNew.GetLength(1); j++)
                {
                    label3.Text = label3.Text + ("   ") + arrNew[i, j];
                }
                label3.Text = label3.Text + ("\n");
            }

            label3.Text = label3.Text + ("\n") + (" ");
            

            for (int i = 0; i < 5; i++)
            {
                label3.Text = label3.Text + (" ") + setSum[i];
            }

            MatrixReplace(arrNew);
            GetColumnSum(arrNew,setSum);

            label1.Text = "";
            for (int i = 0; i < arrNew.GetLength(0); i++)
            {
                for (int j = 0; j < arrNew.GetLength(1); j++)
                {
                    label1.Text = label1.Text + ("   ") +  arrNew[i, j];
                } 
                label1.Text = label1.Text + ("\n");
            }

            label1.Text = label1.Text + ("\n") + (" ");
            Array.Sort(setSum);

            for (int i = 0; i < 5; i++)
            {
                label1.Text = label1.Text + (" ") + setSum[i];
            }
        }

        
    }
}
