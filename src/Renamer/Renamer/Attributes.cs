using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renamer {
    public partial class Attributes : Form {
        public Attributes() {
            InitializeComponent();
        }

        private void BTOk_Click(object sender, EventArgs e) {
            /*FileAttributes attributes = File.GetAttributes(@"C:\Users\Admin\Desktop\YOLO Object Detection with OpenCV and Python.url");
            AttributesRemove(new FileInfo(@"C:\Users\Admin\Desktop\YOLO Object Detection with OpenCV and Python.url"), FileAttributes.System);
            FileAttributes sssss = File.GetAttributes(@"C:\Users\Admin\Desktop\YOLO Object Detection with OpenCV and Python.url");
            File.SetAttributes(@"C:\Users\Admin\Desktop\YOLO Object Detection with OpenCV and Python.url", FileAttributes.ReadOnly);*/
            List<Attribs> attribs = GetAttributesControls(this);
        }

        /// <summary>
        /// Get all groupbox and set attributes value
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public List<Attribs> GetAttributesControls(Control owner) {
            List<Attribs> attribs = new List<Attribs>();
            foreach (Control c in owner.Controls) {
                if (c.GetType() == typeof(GroupBox)) {      
                    if (c.HasChildren) {
                        if (c.Text == "Hidden") {
                            attribs.Add(new Attribs(GetAttributesValueControls(c.Controls), FileAttributes.Hidden));
                        } else if (c.Text == "System") {
                            AttributeValues attributeValues = GetAttributesValueControls(c.Controls);
                            attribs.Add(new Attribs(GetAttributesValueControls(c.Controls), FileAttributes.System));
                        } else if (c.Text == "Archived") {
                            AttributeValues attributeValues = GetAttributesValueControls(c.Controls);
                            attribs.Add(new Attribs(GetAttributesValueControls(c.Controls), FileAttributes.Archive));
                        } else if (c.Text == "Read only") {
                            AttributeValues attributeValues = GetAttributesValueControls(c.Controls);
                            attribs.Add(new Attribs(GetAttributesValueControls(c.Controls), FileAttributes.ReadOnly));
                        }
                    }
                }
            }
            return attribs;
        }


        /// <summary>
        /// Get all radiobutton by groupbox and get attributes value
        /// </summary>
        /// <param name="cc"></param>
        /// <returns></returns>
        public AttributeValues GetAttributesValueControls(Control.ControlCollection cc) {
            AttributeValues attributeValues = AttributeValues.NoChange;
            foreach (Control c in cc) {
                if (c.GetType() == typeof(RadioButton)) {

                    if (c.Text == "No Change") {
                        if (((RadioButton)c).Checked) {
                            attributeValues = AttributeValues.NoChange;
                        }
                    } else if (c.Text == "Unchecked") {
                        if (((RadioButton)c).Checked) {
                            attributeValues = AttributeValues.Unchecked;
                        }
                    } else if (c.Text == "Checked") {
                        if (((RadioButton)c).Checked) {
                            attributeValues = AttributeValues.Checked;
                        }
                    }
                }
            }
            return attributeValues;
        }

        /// <summary>
        /// Addes the given FileAttributes to the given File.
        /// It's possible to combine FileAttributes: FileAttributes.Hidden | FileAttributes.ReadOnly
        /// </summary>
        public void AttributesSet(FileInfo pFile, FileAttributes pAttributes) {
            pFile.Attributes = pFile.Attributes | pAttributes;
            pFile.Refresh();
        }

        /// <summary>
        /// Removes the given FileAttributes from the given File.
        /// It's possible to combine FileAttributes: FileAttributes.Hidden | FileAttributes.ReadOnly
        /// </summary>
        public void AttributesRemove(FileInfo pFile, FileAttributes pAttributes) {
            pFile.Attributes = pFile.Attributes & ~pAttributes;
            pFile.Refresh();
        }

        /// <summary>
        /// Checks the given File on the given Attributes.
        /// It's possible to combine FileAttributes: FileAttributes.Hidden | FileAttributes.ReadOnly
        /// </summary>
        /// <returns>True if any Attribute is set, False if non is set</returns>
        public bool AttributesIsAnySet(FileInfo pFile, FileAttributes pAttributes) {
            return ((pFile.Attributes & pAttributes) > 0);
        }

        /// <summary>
        /// Checks the given File on the given Attributes.
        /// It's possible to combine FileAttributes: FileAttributes.Hidden | FileAttributes.ReadOnly
        /// </summary>
        /// <returns>True if all Attributes are set, False if any is not set</returns>
        public bool AttributesIsSet(FileInfo pFile, FileAttributes pAttributes) {
            return (pAttributes == (pFile.Attributes & pAttributes));
        }
    }

    public enum AttributeValues {
        NoChange,
        Checked,
        Unchecked
    }

    public class Attribs {

        private FileAttributes attribute;
        private AttributeValues attributeValue;

        public Attribs(AttributeValues attributeValue, FileAttributes attributes) {
            this.attributeValue = attributeValue;
            this.attribute = attributes;
        }

        public FileAttributes Attribute { get => attribute; }
        private AttributeValues AttributeValue { get => attributeValue; }
    }

}

