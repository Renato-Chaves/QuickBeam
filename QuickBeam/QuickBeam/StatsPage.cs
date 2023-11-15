using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ProgressBar = System.Windows.Forms.ProgressBar;
using TrackBar = System.Windows.Forms.TrackBar;

namespace QuickBeam
{
    public partial class StatsPage : Form
    {
        Stopwatch timer;
        static StatsPage instance;
        int sortType;
        int selectedCase = 0;
        string selectedCaseText;
        float elapsedTime;
        int moves = 0;
        int steps = 0;
        string result;
        string[,] bigONotation;

        public StatsPage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            bigONotation = new string[5, 3] { { "O(n)", "O(n2)", "O(n²)" },
                                              { "O(n∗log n)", "O(n∗log n)", "O(n∗log n)" },
                                              { "O(n∗log n)", "O(n∗log n)", "O(n∗log n)" },
                                              { "O(n∗log n)", "O(n²)", "O(n²)" },
                                              { "O(n∗log n)", "O(n∗log n)", "O(n²)" }};
        }

        public static StatsPage GetInstance()
        {
            if (instance == null) instance = new StatsPage();
            return instance;
        }

        public void SwitchToPage(int _sortType)
        {
            this.Show();
            LoadInfo(_sortType);
        }

        private void LoadInfo(int _sortType)
        {
            SliderInputText.Text = "Qtd de Números: " + NumberQuantitySlider.Value.ToString();
            InputQuantityText.Text = NumberQuantitySlider.Value.ToString();
            ElapsedTimeText.Text = String.Empty;
            StepsText.Text = String.Empty;
            MovesText.Text = String.Empty;
            BigOText.Text = String.Empty;

            sortType = _sortType;
            switch (_sortType)
            {
                case 0:
                    SortingTitle.Text = "Bubble Sort";
                    break;
                case 1:
                    SortingTitle.Text = "Merge Sort";
                    break;
                case 2:
                    SortingTitle.Text = "Heap Sort";
                    break;
                case 3:
                    SortingTitle.Text = "Shell Sort";
                    break;
                case 4:
                    SortingTitle.Text = "Quick Sort";
                    break;
            }
        }

        private void CaseBtn_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "BestCaseBtn":
                    SortingCaseText.Text = "Melhor";
                    selectedCaseText = "Melhor";
                    selectedCase = 0;
                    break;
                case "AverageCaseBtn":
                    SortingCaseText.Text = "Médio";
                    selectedCaseText = "Médio";
                    selectedCase = 1;
                    break;
                case "WorstCaseBtn":
                    SortingCaseText.Text = "Pior";
                    selectedCaseText = "Pior";
                    selectedCase = 2;
                    break;
            }
        }

        private void BackArrowBtn_Click(object sender, EventArgs e)
        {
            Menu.GetInstance().SwitchToPage();
            this.Hide();
        }

        private void Slider_Drag(object sender, MouseEventArgs e)
        {
            ProgressBar progressBar = (sender as ProgressBar);
            if (Cursor.Position.X > progressBar.Location.X)
            {
                progressBar.Value = ((Cursor.Position.X - progressBar.Location.X) * 100) / (Cursor.Position.X - progressBar.Location.X + progressBar.Width);
            }
        }

        private void BeginSimBtn_Click(object sender, EventArgs e)
        {

            int[] inputNumbers = new int[NumberQuantitySlider.Value];
            moves = 0;
            steps = 0;

            switch (selectedCase)
            {
                case 0:
                    for (int i = 0; i < inputNumbers.Length; i++)
                    {
                        inputNumbers[i] = i + 1;
                    }
                    break;
                case 1:
                    List<int> vals = GenerateRandom(NumberQuantitySlider.Value);
                    //MessageBox.Show("Result: " + vals.Count);
                    for (int i = 0; i < vals.Count; i++)
                    {
                        inputNumbers[i] = vals[i];
                    }
                    break;
                case 2:
                    for (int i = inputNumbers.Length - 1; i >= 0; i--)
                    {
                        inputNumbers[i] = inputNumbers.Length - (i);
                    }
                    break;
            }


            timer = new Stopwatch();
            switch (sortType)
            {
                case 0: //Bubble Sort
                    BubbleSort(inputNumbers);
                    break;
                case 1: //Merge Sort
                    List<int> unsorted = new List<int>();
                    foreach (int aa in inputNumbers)
                    {
                        unsorted.Add(aa);
                    }
                    timer.Start();
                    List<int> resultList = MergeSort(unsorted);
                    timer.Stop();
                    elapsedTime = (float)timer.ElapsedTicks / 10000;
                    string result = "Entrada: ";

                    foreach(int aa in inputNumbers)
                    {
                        result += aa+" ";
                    }
                    result += "\r\n----------\r\n";
                    result += "Saida: ";


                    foreach (int aa in resultList)
                    {
                        result += aa.ToString()+" ";
                    }
                    OutputText.Text = result;
                    Menu.GetInstance().SetHistory(1, selectedCaseText, NumberQuantitySlider.Value.ToString(), elapsedTime.ToString(), steps.ToString(), moves.ToString(), bigONotation[sortType, selectedCase].ToString());
                    break;
                case 2: //Heap Sort
                    HeapSort(inputNumbers, inputNumbers.Length);
                    break;
                case 3: //Shell Sort
                    ShellSort(inputNumbers, inputNumbers.Length);
                    break;
                case 4: //Quick Sort

                    result = "Entrada: ";

                    foreach (int aa in inputNumbers)
                    {
                        result += aa + " ";
                    }
                    result += "\r\n----------\r\n";
                    result += "Saida: ";

                    timer.Start();
                    QuickSort(inputNumbers, 0, inputNumbers.Length-1);
                    timer.Stop();

                    foreach (int aa in inputNumbers)
                    {
                        result += aa + " ";
                    }
                    OutputText.Text = result;
                    elapsedTime = (float)timer.ElapsedTicks / 10000;
                    Menu.GetInstance().SetHistory(4, selectedCaseText, NumberQuantitySlider.Value.ToString(), elapsedTime.ToString(), steps.ToString(), moves.ToString(), bigONotation[sortType, selectedCase].ToString());
                    break;
            }

            BigOText.Text = bigONotation[sortType, selectedCase].ToString();
            InputQuantityText.Text = NumberQuantitySlider.Value.ToString();
            ElapsedTimeText.Text = elapsedTime.ToString() + "ms";
            StepsText.Text = steps.ToString();
            MovesText.Text = moves.ToString();

        }

        //Bubble Sort
        private void BubbleSort(int[] input)
        {
            int[] a = input; // int numbers through array
            string result = "Entrada: ";
            foreach (int aa in a) //writting array
                result += (aa.ToString() + " ");
            result += "\r\n----------\r\n";
            int t;

            timer.Start();
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                        moves++;
                    }
                    steps++;

                }
            }
            timer.Stop();
            result += "Resultado: ";
            foreach (int aa in a) //writting array
                result += (aa.ToString() + " ");
            OutputText.Text = result;
            elapsedTime = (float)timer.ElapsedTicks / 10000;
            //MessageBox.Show("Elapsed Time: " + elapsedTime + "ms\n Index Moves: " + steps + "\n Value Moves: " + moves + " \nThe Sorted array\n" + result);
            Menu.GetInstance().SetHistory(0, selectedCaseText, NumberQuantitySlider.Value.ToString(), elapsedTime.ToString(), steps.ToString(), moves.ToString(), bigONotation[sortType, selectedCase].ToString());
            a = null;
        }

        //Merge Sort
        private List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
                steps++;
                moves++;
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
                steps++;
                moves++;
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                steps++;
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                    moves += 2;
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                    moves += 2;
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                    moves+=2;
                }
            }
            return result;
        }

        //Heap Sort
        void HeapSort(int[] arr, int n)
        {
            string result = "Entrada: ";
            foreach (int aa in arr) //writting array
                result += (aa.ToString() + " ");
            result += "\r\n----------\r\n";

            timer.Start();
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
                steps++;
            }
            for (int i = n - 1; i >= 0; i--)
            {
                steps++;
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr, i, 0);
            }
            timer.Stop();
            elapsedTime = (float)timer.ElapsedTicks / 10000;

            result += "Saida: ";
            foreach (int aa in arr) //writting array
                result += (aa.ToString() + " ");
            Menu.GetInstance().SetHistory(2, selectedCaseText, NumberQuantitySlider.Value.ToString(), elapsedTime.ToString(), steps.ToString(), moves.ToString(), bigONotation[sortType, selectedCase].ToString());
            OutputText.Text = result;
        }
        void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
                moves++;
            }
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
                moves++;
            }
            if (largest != i)
            {
                moves++;
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, n, largest);
            }
        }

        //Shell Sort
        void ShellSort(int[] arr, int array_size)
        {
            string result = "Entrada: ";
            foreach (int aa in arr) //writting array
                result += (aa.ToString() + " ");
            result += "\r\n----------\r\n";

            int i, j, inc, temp;
            inc = 3;
            timer.Start();
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        steps++;
                        moves++; ;
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                    moves++;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }

            timer.Stop();
            elapsedTime = (float)timer.ElapsedTicks / 10000;

            result += "Saida: ";
            foreach (int aa in arr) //writting array
                result += (aa.ToString() + " ");
            Menu.GetInstance().SetHistory(3, selectedCaseText, NumberQuantitySlider.Value.ToString(), elapsedTime.ToString(), steps.ToString(), moves.ToString(), bigONotation[sortType, selectedCase].ToString());
            OutputText.Text = result;
        }

        //Quick Sort

        void QuickSort(int[] arr, int left, int right)
        {

            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                    steps++;
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                    steps++;
                }
            }
        }

        int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            moves++;
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                    steps++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                    steps++;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    moves += 2;

                }
                else
                {
                    return right;
                }
            }
        }

        private void NumberQuantitySlider_Scroll(object sender, EventArgs e)
        {
            SliderInputText.Text = "Qtd de Números: " + (sender as TrackBar).Value.ToString();
        }

        static Random random = new Random();

        public static List<int> GenerateRandom(int count)
        {
            // generate count random values.
            HashSet<int> candidates = new HashSet<int>();
            while (candidates.Count < count)
            {
                // May strike a duplicate.
                candidates.Add(random.Next(1, count + 1));
            }

            // load them in to a list.
            List<int> result = new List<int>();
            result.AddRange(candidates);

            // shuffle the results:
            int i = result.Count;
            while (i > 1)
            {
                i--;
                int k = random.Next(i + 1);
                int value = result[k];
                result[k] = result[i];
                result[i] = value;
            }
            return result;
        }

        private void FontSizeSlider_Scroll(object sender, EventArgs e)
        {
            int value = (sender as TrackBar).Value;
            FontSliderText.Text = "Tamanho da Fonte: " + value.ToString();
            OutputText.Font = new Font(OutputText.Font.FontFamily, value);
        }
    }
}
