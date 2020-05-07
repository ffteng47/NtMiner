﻿using NTMiner.Core;
using NTMiner.Core.Gpus;
using NTMiner.Vms;

namespace NTMiner.MinerStudio.Vms {
    public class GpuNameCountViewModel : ViewModelBase, IGpuNameCount {
        private GpuType _gpuType;
        private string _name;
        private ulong _totalMemory;
        private int _count;

        public GpuNameCountViewModel(IGpuNameCount data) {
            _gpuType = data.GpuType;
            _name = data.Name;
            _totalMemory = data.TotalMemory;
            _count = data.Count;
        }

        public int Count {
            get => _count;
            set {
                if (_count != value) {
                    _count = value;
                    OnPropertyChanged(nameof(Count));
                }
            }
        }

        public GpuType GpuType {
            get => _gpuType;
            set {
                if (_gpuType != value) {
                    _gpuType = value;
                    OnPropertyChanged(nameof(GpuType));
                }
            }
        }

        public string Name {
            get => _name;
            set {
                if (_name != value) {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public ulong TotalMemory {
            get => _totalMemory;
            set {
                if (_totalMemory != value) {
                    _totalMemory = value;
                    OnPropertyChanged(nameof(TotalMemory));
                }
            }
        }

        public bool IsValid() {
            return GpuName.IsValid(this.GpuType, this.Name, this.TotalMemory);
        }

        public override bool Equals(object obj) {
            if (obj == null) {
                return false;
            }
            return this.ToString() == obj.ToString(); ;
        }

        public override int GetHashCode() {
            return this.ToString().GetHashCode();
        }

        /// <summary>
        /// 该ToString字符串会被作为redis key使用
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return GpuName.Format(this.GpuType, this.Name, this.TotalMemory);
        }
    }
}