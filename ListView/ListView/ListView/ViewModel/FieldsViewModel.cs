using ListView.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace ListView.ViewModel
{
    public class FieldsViewModel : INotifyPropertyChanged
    {
        public FieldsViewModel()
        {
            IEnumerable<FieldModel> data = DummyFields().Select((f, i) => new FieldModel() { Area = f.Area, Description = f.Description, Name = f.Name, Index = i });
            Fields = new ObservableCollection<FieldModel>(data);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<FieldModel> Fields { get; set; }

        private List<FieldModel> DummyFields()
        {
            return new List<FieldModel>()
            {
                new FieldModel() { Name ="Hinter dem Misthaufen", Area = 69.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Am Kuhhintern", Area = 79.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Vor dem See", Area = 5.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Wiesenglück", Area = 78.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Hinterholz", Area = 1.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Hinter dem Misthaufen", Area = 69.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Am Kuhhintern", Area = 79.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Vor dem See", Area = 5.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Wiesenglück", Area = 78.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Hinterholz", Area = 1.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Hinter dem Misthaufen", Area = 69.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Am Kuhhintern", Area = 79.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Vor dem See", Area = 5.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Wiesenglück", Area = 78.45, Description = "Am Wald drei mal abbiegen und dann rechts"},
                new FieldModel() { Name ="Hinterholz", Area = 1.45, Description = "Am Wald drei mal abbiegen und dann rechts"}
            };
        }
    }
}
