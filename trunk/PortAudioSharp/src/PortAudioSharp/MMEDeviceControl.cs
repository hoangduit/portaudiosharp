 /*
  * PortAudioSharp - PortAudio bindings for .NET
  * Copyright 2006, 2007, 2008, 2009 Riccardo Gerosa and individual contributors as indicated
  * by the @authors tag. See the copyright.txt in the distribution for a
  * full listing of individual contributors.
  *
  * This is free software; you can redistribute it and/or modify it
  * under the terms of the GNU Lesser General Public License as
  * published by the Free Software Foundation; either version 2.1 of
  * the License, or (at your option) any later version.
  *
  * This software is distributed in the hope that it will be useful,
  * but WITHOUT ANY WARRANTY; without even the implied warranty of
  * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
  * Lesser General Public License for more details.
  *
  * You should have received a copy of the GNU Lesser General Public
  * License along with this software; if not, write to the Free
  * Software Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA
  * 02110-1301 USA, or see the FSF site: http://www.fsf.org.
  */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PortAudioSharp
{
	/// <summary>
	/// Description of MMEDeviceControl.
	/// </summary>
	public partial class MMEDeviceControl : UserControl, IDeviceControl
	{
		private PortAudioSharp.PortAudio.PaHostApiInfo paHostApiInfo;
		private IUpdatableControl updatableControl;
		
		public bool Valid { get { return true; } }
		public int BufferSize { get { return (int) bufferSizeComboBox.SelectedItem; } }
		
		public MMEDeviceControl(PortAudio.PaHostApiInfo paHostApiInfo, IUpdatableControl updatableControl)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.paHostApiInfo = paHostApiInfo;
			this.updatableControl = updatableControl;
		}
		
		void MMEDeviceControlLoad(object sender, EventArgs e)
		{			
			int deviceCount = PortAudio.Pa_GetDeviceCount();
			Console.WriteLine("Device count: " + paHostApiInfo.deviceCount + " default input device: " + paHostApiInfo.defaultInputDevice);
			
			inputDeviceComboBox.Items.Clear();
			outputDeviceComboBox.Items.Clear();
			for (int i = 0; i < deviceCount; i++) {
				PortAudio.PaDeviceInfo paDeviceInfo = PortAudio.Pa_GetDeviceInfo(i);
				PortAudio.PaHostApiInfo paHostApi = PortAudio.Pa_GetHostApiInfo(paDeviceInfo.hostApi);
				if (paHostApi.type == PortAudio.PaHostApiTypeId.paMME) {
					Console.WriteLine("\n#" + i + "\n" + paDeviceInfo);
					if (paDeviceInfo.maxInputChannels > 0) {
						inputDeviceComboBox.Items.Add(new DeviceItem(i, paDeviceInfo));
						if (i == paHostApiInfo.defaultInputDevice) { 
							inputDeviceComboBox.SelectedIndex = inputDeviceComboBox.Items.Count - 1;
						}
					}
					if (paDeviceInfo.maxOutputChannels > 0) {
						outputDeviceComboBox.Items.Add(new DeviceItem(i, paDeviceInfo));
						if (i == paHostApiInfo.defaultOutputDevice) { 
							outputDeviceComboBox.SelectedIndex = outputDeviceComboBox.Items.Count - 1;
						}
					}
				}
			}
			
			bufferSizeComboBox.Items.Clear();
			int bufferSize = 256;
			while (bufferSize < 44100 / 2) {
				bufferSizeComboBox.Items.Add(bufferSize);
				bufferSize *= 2;
			}
			bufferSizeComboBox.SelectedIndex = 5;
		}
		
		void BufferSizeComboBoxSelectionChangeCommitted(object sender, EventArgs e)
		{
			updatableControl.update();
		}
	}
}