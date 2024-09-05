﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_2_semester_1_cs_winforms
{
    class PowerSupplies
    {
        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
            private set
            {
                _count = value;
            }
        }
        public UninterruptivlePowerSupply[] supplies { get; set; }

        public PowerSupplies(int count)
        {
            this.Count = count;
            supplies = new UninterruptivlePowerSupply[count];
            for (int i = 0; i < count; i++)
            {
                supplies[i] = new UninterruptivlePowerSupply();
            }
        }

        public UninterruptivlePowerSupply this[int index]
        {
            get
            {
                return supplies[index];
            }
            set
            {
                supplies[index] = value;

            }
        }

         public long SelectionSort(Func<UninterruptivlePowerSupply, UninterruptivlePowerSupply, bool> compare, Action action)
        {
            var globalWatch = new Stopwatch();
            globalWatch.Start();

            int length = Count;
            UninterruptivlePowerSupply temp;
            for (int j = 0; j < length - 1; j++)
            {
                int min = j;
                for (int i = j + 1; i < length; i++)
                {
                    if (compare(supplies[min], supplies[i]))
                    {
                        min = i;
                    }
                }
                temp = supplies[j];
                supplies[j] = supplies[min];
                supplies[min] = temp;
                action();
            }
            globalWatch.Stop();
            return globalWatch.ElapsedMilliseconds;
        }

        public long BubbleSort(Func<UninterruptivlePowerSupply, UninterruptivlePowerSupply, bool> compare, Action action)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            UninterruptivlePowerSupply temp;
            for (int j = 0; j < Count - 1; j++)
            {
                for (int i = 0; i < Count - 1; i++)
                {
                    if (compare(supplies[i], supplies[i + 1]))
                    {
                        temp = supplies[i + 1];
                        supplies[i + 1] = supplies[i];
                        supplies[i] = temp;
                        action();
                    }
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public long ShakerSort(Func<UninterruptivlePowerSupply, UninterruptivlePowerSupply, bool> compare, Action action)
        {
            bool isSwapped = true;
            int start = 0;
            int end = Count;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            while (isSwapped == true)
            {
                isSwapped = false;
                for (int i = start; i < end - 1; ++i)
                {
                    if (compare(supplies[i], supplies[i + 1]))
                    {
                        (supplies[i + 1], supplies[i]) = (supplies[i], supplies[i + 1]);
                        action();
                        isSwapped = true;
                    }
                }
                if (isSwapped == false)
                    break;
                isSwapped = false;
                end = end - 1;
                for (int i = end - 1; i >= start; i--)
                {
                    if (compare(supplies[i], supplies[i + 1]))
                    {
                        (supplies[i + 1], supplies[i]) = (supplies[i], supplies[i + 1]);
                        action();
                        isSwapped = true;
                    }
                }
                start = start + 1;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public long ShellSort(Func<UninterruptivlePowerSupply, UninterruptivlePowerSupply, bool> compare, Action action)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int interval = Count / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < Count; i++)
                {
                    var currentKey = supplies[i];
                    var k = i;
                    while (k >= interval && compare(supplies[k - interval], currentKey))
                    {
                        supplies[k] = supplies[k - interval];
                        action();
                        k -= interval;
                    }
                    supplies[k] = currentKey;
                    action();
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

    }
}
