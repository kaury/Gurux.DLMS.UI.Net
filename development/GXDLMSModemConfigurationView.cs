//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSModemConfigurationView.cs $
//
// Version:         $Revision: 8933 $,
//                  $Date: 2016-11-23 09:20:07 +0200 (ke, 23 marras 2016) $
//                  $Author: gurux01 $
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// This file is a part of Gurux Device Framework.
//
// Gurux Device Framework is Open Source software; you can redistribute it
// and/or modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; version 2 of the License.
// Gurux Device Framework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License for more details.
//
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    [GXDLMSViewAttribute(typeof(Gurux.DLMS.Objects.GXDLMSModemConfiguration))]
    public partial class GXDLMSModemConfigurationView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSModemConfigurationView()
        {
            InitializeComponent();
        }
        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user)
        {
            GXDLMSModemConfiguration target = Target as GXDLMSModemConfiguration;
            if (index == 3)
            {
                if (target.InitialisationStrings == null)
                {
                    this.InitialisationTB.Text = "";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var it in target.InitialisationStrings)
                    {
                        sb.Append(it.Request);
                        sb.Append(" ");
                        sb.Append(it.Response);
                        sb.Append(" ");
                        sb.Append(it.Delay.ToString());
                        sb.Append(Environment.NewLine);
                    }
                    this.InitialisationTB.Text = sb.ToString();
                }
            }
            else if (index == 4)
            {
                if (target.ModemProfile == null)
                {
                    this.ModemProfileTB.Text = "";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (string it in target.ModemProfile)
                    {
                        sb.AppendLine(it);
                    }
                    this.ModemProfileTB.Text = sb.ToString();
                }
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access)
        {
        }

        public System.Windows.Forms.ErrorProvider ErrorProvider
        {
            get
            {
                return errorProvider1;
            }
        }

        public string Description
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {

        }

        #endregion




    }
}
