//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSIp4SetupView.cs $
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
    [GXDLMSViewAttribute(typeof(GXDLMSIp4Setup))]
    public partial class GXDLMSIp4SetupView : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSIp4SetupView()
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
            if (index == 8)
            {
                GXDLMSIp4Setup target = Target as GXDLMSIp4Setup;
                UseDhcpCp.CheckedChanged -= new System.EventHandler(UseDHCCB_CheckedChanged);
                this.UseDhcpCp.Checked = target.UseDHCP;
                UseDhcpCp.CheckedChanged += new System.EventHandler(UseDHCCB_CheckedChanged);
            }
            else if (index != 0)
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access)
        {
            if (index == 8)
            {
                this.UseDhcpCp.Enabled = (access & AccessMode.Write) != 0;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode)
        {
        }


        public void PreAction(ActionType type, ValueEventArgs arg)
        {

        }

        public void PostAction(ActionType type, ValueEventArgs arg)
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

        private void UseDHCCB_CheckedChanged(object sender, EventArgs e)
        {
            bool check = UseDhcpCp.Checked;
            (Target as GXDLMSIp4Setup).UseDHCP = check;
            Target.UpdateDirty(8, check);
            errorProvider1.SetError(UseDhcpCp, Properties.Resources.ValueChangedTxt);
        }
    }
}
