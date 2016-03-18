using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Android_gTools.JsonUtils;
using Android_gTools.XmlUtils;

namespace Android_gTools
{
    public partial class Main : Form
    {
        private XmlTreeConfig config;
        private String content = "";
        private String jsonContent = "";
        public Main()
        {
            InitializeComponent();
            config = new XmlTreeConfig(tv_xml);
        }
          private void Init()
        {
            config.Init(richTextBox1.Text);
            content = richTextBox1.Text;
        }

     
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("安卓爱好者：keyboard3\n有问题请联系我：qq:1486416565\n", "作者信息"));
        }

        private void btn_java_init_Click(object sender, EventArgs e)
        {
            if (content != "")
            {
                if (MessageBox.Show("确认初始化树？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.OK)
                {
                    Init();
                }
            }
            else
            {
                Init();
            }
        }

        private void btn_style_init_Click(object sender, EventArgs e)
        {
            if (content != "")
            {
                if (MessageBox.Show("确认初始化树？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.OK)
                {
                    Init();
                }
            }
            else
            {
                Init();
            }
            

        }

        private void btn_viewHolder_init_Click(object sender, EventArgs e)
        {
            if (content != "")
            {
                if (MessageBox.Show("确认初始化树？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                    DialogResult.OK)
                {
                    Init();
                }
            }
            else
            {
                Init();
            }
        }

        private void btn_java_ok_Click(object sender, EventArgs e)
        {
            if (content == "")
            {
                Init();
               
            }

            BaseXmlHandler xmlHandler = XmlHanlderFactory.getVaribleXmlHandler();
            configVaribleXml();
            VaribleXmlHandler.type = VaribleXmlHandler.javaTypeEnum.standard;
            richTextBox1.Text = xmlHandler.excute(tv_xml.SelectedNode);
        }

        private void configVaribleXml()
        {
            String modifier_str = "";
            if (rb_java_public.Checked)
            {
                modifier_str = "public";
            }
            else if (rb_java_private.Checked)
            {
                modifier_str = "private";
            }
            else if (rb_java_final.Checked)
            {
                modifier_str = "final";
            }
            else if (rb_java_static.Checked)
            {
                modifier_str = "static";
            }
            VaribleXmlHandler.isUpper = cbx_java_isUpper.Checked;
            VaribleXmlHandler.modifier = modifier_str;
            VaribleXmlHandler.prefix = tbx_java_prefix.Text.Trim();
            VaribleXmlHandler.subffix = tbx_java_suffix.Text.Trim();
        }

        private void btn_style_ok_Click(object sender, EventArgs e)
        {
            if (content == "")
            {
                Init();
            }
            BaseXmlHandler styleHandler = XmlHanlderFactory.getStyleXmlHandler();
            styleHandler.RegexStr = tbx_style_item_name.Text.Trim();
            StyleXmlHandler.textRegexStr = tbx_style_item_value.Text.Trim();
            StyleXmlHandler.styleName = tbx_style_name.Text.Trim();
            richTextBox1.Text = styleHandler.excute(tv_xml.SelectedNode);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //java
            rb_java_private.Checked = true;
            tbx_java_prefix.Text = "m";
            //style
            tbx_style_item_name.Text = "text";
            tbx_style_item_value.Text = "id";
            tbx_style_name.Text = "";
            //viewholder
            rb_viewholder_public.Checked = true;
            tbx_viewholder_prefix.Text = "m";
            //json
            tbx_json_name.Text = "javabean";
        }

        private void btn_viewHolder_ok_Click(object sender, EventArgs e)
        {
            if (content == "")
            {
                Init();

            }

            BaseXmlHandler xmlHandler = XmlHanlderFactory.getListViewXmlHandler();
            String modifier_str = "";
            if (rb_viewholder_public.Checked)
            {
                modifier_str = "public";
            }
            else if (rb_viewholder_private.Checked)
            {
                modifier_str = "private";
            }
            else if (rb_viewholder_final.Checked)
            {
                modifier_str = "final";
            }
            else if (rb_viewholder_static.Checked)
            {
                modifier_str = "static";
            }
            ListViewXmlHandler.isUpper = cbx_viewholder_isUpper.Checked;
            ListViewXmlHandler.modifier = modifier_str;
            ListViewXmlHandler.prefix = tbx_viewholder_prefix.Text.Trim();
            ListViewXmlHandler.subffix = tbx_viewholder_suffix.Text.Trim();
            richTextBox1.Text = xmlHandler.excute(tv_xml.SelectedNode);
        }

        private void btn_json_ok_Click(object sender, EventArgs e)
        {
            if (jsonContent == "")
            {
                initJson();
            }
            JsonUtil.Name = tbx_json_name.Text.Trim();
            richTextBox1.Text = JsonUtil.parseJson(jsonContent);
        }

        private void btn_json_init_Click(object sender, EventArgs e)
        {
            initJson();
        }

        void initJson()
        {
            jsonContent = richTextBox1.Text;
        }

        private void btn_java_Annotations_Click(object sender, EventArgs e)
        {
            if (content == "")
            {
                Init();
            }
            BaseXmlHandler xmlHandler = XmlHanlderFactory.getVaribleXmlHandler();
            configVaribleXml();
            VaribleXmlHandler.type = VaribleXmlHandler.javaTypeEnum.annotations;
            richTextBox1.Text = xmlHandler.excute(tv_xml.SelectedNode);
        }

        private void btn_java_ViewInject_Click(object sender, EventArgs e)
        {
            if (content == "")
            {
                Init();
            }
            BaseXmlHandler xmlHandler = XmlHanlderFactory.getVaribleXmlHandler();
            configVaribleXml();
            VaribleXmlHandler.type = VaribleXmlHandler.javaTypeEnum.xutils;
            richTextBox1.Text = xmlHandler.excute(tv_xml.SelectedNode);
        }
    }
}
