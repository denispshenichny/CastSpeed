using BenchmarkDotNet.Attributes;
using DevExpress.XtraCharts.ModelSupport.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastSpeed {
    public class Benchmark {
        List<object> listObjects;
        List<ComplexSeriesConfigurator> listBase;
        List<BubbleSeriesConfigurator> listDerived;
        const int Count = 100000;
        [GlobalSetup]
        public void Setup() {
            listObjects = new List<object>(Count);
            listBase = new List<ComplexSeriesConfigurator>(Count);
            listDerived = new List<BubbleSeriesConfigurator>(Count);

            for(int i = 0; i < listObjects.Count; i++) {
                listObjects.Add(new BubbleSeriesConfigurator());
                listBase.Add(new BubbleSeriesConfigurator());
                listDerived.Add(new BubbleSeriesConfigurator());
            }
        }

        [Benchmark]
        public void CastObjects_ToBase() {
            for(int i = 0; i < listObjects.Count; i++) {
                var cfgCommon = listObjects[i] as ComplexSeriesConfigurator;
                if(cfgCommon == null)
                    throw new Exception();
            }                
        }
        [Benchmark]
        public void CastObjects_ToDerived() {
            for(int i = 0; i < listObjects.Count; i++) {
                var cfgCommon = listObjects[i] as BubbleSeriesConfigurator;
                if(cfgCommon == null)
                    throw new Exception();
            }
        }
        [Benchmark]
        public void CastBase_ToBase() {
            for(int i = 0; i < listBase.Count; i++) {
                var cfgCommon = listBase[i] as ComplexSeriesConfigurator;
                if(cfgCommon == null)
                    throw new Exception();
            }
        }
        [Benchmark]
        public void CastBase_ToDerived() {
            for(int i = 0; i < listBase.Count; i++) {
                var cfgCommon = listBase[i] as BubbleSeriesConfigurator;
                if(cfgCommon == null)
                    throw new Exception();
            }
        }
        [Benchmark]
        public void CastDerived_ToBase() {
            for(int i = 0; i < listDerived.Count; i++) {
                var cfgCommon = listDerived[i] as ComplexSeriesConfigurator;
                if(cfgCommon == null)
                    throw new Exception();
            }
        }
        [Benchmark]
        public void CastDerived_ToDerived() {
            for(int i = 0; i < listDerived.Count; i++) {
                var cfgCommon = listDerived[i] as BubbleSeriesConfigurator;
                if(cfgCommon == null)
                    throw new Exception();
            }
        }
    }
}
