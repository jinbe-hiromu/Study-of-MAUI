﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp
{
    public class BindableBase : INotifyPropertyChanged
    {
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Set the property with the specified value. If the value is not equal with the field then the field is
        /// set, a PropertyChanged event is raised and it returns true.
        /// </summary>
        /// <typeparam name="T">Type of the property.</typeparam>
        /// <param name="field">Reference to the backing field of the property.</param>
        /// <param name="value">The new value for the property.</param>
        /// <param name="propertyName">The property name. This optional parameter can be skipped
        /// because the compiler is able to create it automatically.</param>
        /// <returns>True if the value has changed, false if the old and new value were equal.</returns>
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) { return false; }
            field = value;
            RaisePropertyChanged(propertyName);
            return true;
        }
        /// <summary>
        /// Raises the <see cref="E:PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">The property name of the property that has changed.
        /// This optional parameter can be skipped because the compiler is able to create it automatically.</param>
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Raises the <see cref="E:PropertyChanged"/> event.
        /// </summary>
        /// <param name="e">The <see cref="PropertyChangedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
