﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 16.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Senparc.Xncf.XncfBuidler.Templates.Areas.Admin.Pages.MyApps
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Areas\Admin\Pages\MyApps\DatabaseSample.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class DatabaseSample : DatabaseSampleBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("@page\r\n@model ");
            
            #line 7 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Areas\Admin\Pages\MyApps\DatabaseSample.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OrgName));
            
            #line default
            #line hidden
            this.Write(".Xncf.");
            
            #line 7 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Areas\Admin\Pages\MyApps\DatabaseSample.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write(".Areas.");
            
            #line 7 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Areas\Admin\Pages\MyApps\DatabaseSample.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write(@".Pages.DatabaseSample
@{
    ViewData[""Title""] = ""数据库操作示例"";
    Layout = ""_Layout_Vue"";
}
@section HeaderContent{
    <style>
        .box {
            margin: 30px auto;
            text-align: center;
            padding: 80px;
        }
    </style>
}
@section breadcrumbs {
    <el-breadcrumb-item>扩展模块</el-breadcrumb-item>
    <el-breadcrumb-item>");
            
            #line 23 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Areas\Admin\Pages\MyApps\DatabaseSample.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write("</el-breadcrumb-item>\r\n    <el-breadcrumb-item>数据库操作示例</el-breadcrumb-item>\r\n}\r\n\r" +
                    "\n<div>\r\n    <el-container>\r\n        <el-header class=\"module-header\">\r\n         " +
                    "   <span class=\"start-title\"> <i class=\"fa fa-dot-circle-o\"></i>&nbsp;<span clas" +
                    "s=\"module-header-v\">扩展页面测试模块</span></span>\r\n        </el-header>\r\n        <el-ma" +
                    "in v-if=\"moduleData\">\r\n            <h4>{{moduleData.xncfModuleDto.description}}<" +
                    "/h4>\r\n            <br />\r\n            <h4>安装时间：{{formaTableTime(moduleData.color" +
                    "Dto.addTime)}}</h4>\r\n            <div class=\"box\" :style=\"{backgroundColor}\">\r\n\r" +
                    "\n                <el-button @@click=\"changeColor(\'Brighten\')\"><i class=\"fa fa-ta" +
                    "chometer\"></i> 变亮</el-button>\r\n                <el-button @@click=\"changeColor(\'" +
                    "Darken\')\" type=\"info\"><i class=\"fa fa-moon-o\"></i> 变暗</el-button>\r\n             " +
                    "   <el-button @@click=\"changeColor(\'Random\')\" type=\"success\"><i class=\"fa fa-sun" +
                    "-o\"></i> 随机</el-button>\r\n            </div>\r\n        </el-main>\r\n    </el-contai" +
                    "ner>\r\n</div>\r\n@section scripts{\r\n    <script>\r\n        var app = new Vue({\r\n    " +
                    "        el: \"#app\",\r\n            data() {\r\n                return {\r\n           " +
                    "         moduleData: null,\r\n                    uid: \'\'\r\n                };\r\n   " +
                    "         },\r\n            computed: {\r\n                backgroundColor() {\r\n     " +
                    "               let rgba = `rgba(${this.moduleData.colorDto.red},${this.moduleDat" +
                    "a.colorDto.green},${this.moduleData.colorDto.blue},1)`\r\n                    retu" +
                    "rn rgba;\r\n                }\r\n            },\r\n            mounted() {\r\n          " +
                    "      this.getDetail();\r\n            },\r\n            methods: {\r\n               " +
                    " async getDetail() {\r\n                    this.uid = resizeUrl().uid\r\n          " +
                    "          const res = await service.get(\'/Admin/");
            
            #line 67 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Areas\Admin\Pages\MyApps\DatabaseSample.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write("/DatabaseSample?handler=Detail&uid=\' + this.uid);\r\n                    this.modul" +
                    "eData = res.data.data;\r\n                },\r\n                // 改变颜色\r\n           " +
                    "     async changeColor(param) {\r\n                    const res = await service.g" +
                    "et(\'/Admin/");
            
            #line 72 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Areas\Admin\Pages\MyApps\DatabaseSample.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write("/DatabaseSample?handler=\' + param + \'&uid=\' + this.uid);\r\n                    thi" +
                    "s.moduleData.colorDto = res.data.data;\r\n                }\r\n            }\r\n      " +
                    "  });\r\n    </script>\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class DatabaseSampleBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
