﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumirArqui.webClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="webClient.WebClienteSoap")]
    public interface WebClienteSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento email del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insertar", ReplyAction="*")]
        ConsumirArqui.webClient.InsertarResponse Insertar(ConsumirArqui.webClient.InsertarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insertar", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirArqui.webClient.InsertarResponse> InsertarAsync(ConsumirArqui.webClient.InsertarRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento email del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Modificar", ReplyAction="*")]
        ConsumirArqui.webClient.ModificarResponse Modificar(ConsumirArqui.webClient.ModificarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Modificar", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirArqui.webClient.ModificarResponse> ModificarAsync(ConsumirArqui.webClient.ModificarRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento email del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        ConsumirArqui.webClient.EliminarResponse Eliminar(ConsumirArqui.webClient.EliminarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirArqui.webClient.EliminarResponse> EliminarAsync(ConsumirArqui.webClient.EliminarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insertar", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirArqui.webClient.InsertarRequestBody Body;
        
        public InsertarRequest() {
        }
        
        public InsertarRequest(ConsumirArqui.webClient.InsertarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string psw;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string telefono;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string categoria;
        
        public InsertarRequestBody() {
        }
        
        public InsertarRequestBody(string email, string psw, string nombre, string apellido, string telefono, string categoria) {
            this.email = email;
            this.psw = psw;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.categoria = categoria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirArqui.webClient.InsertarResponseBody Body;
        
        public InsertarResponse() {
        }
        
        public InsertarResponse(ConsumirArqui.webClient.InsertarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertarResult;
        
        public InsertarResponseBody() {
        }
        
        public InsertarResponseBody(string InsertarResult) {
            this.InsertarResult = InsertarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Modificar", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirArqui.webClient.ModificarRequestBody Body;
        
        public ModificarRequest() {
        }
        
        public ModificarRequest(ConsumirArqui.webClient.ModificarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string psw;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string telefono;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string categoria;
        
        public ModificarRequestBody() {
        }
        
        public ModificarRequestBody(string email, string psw, string nombre, string apellido, string telefono, string categoria) {
            this.email = email;
            this.psw = psw;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.categoria = categoria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirArqui.webClient.ModificarResponseBody Body;
        
        public ModificarResponse() {
        }
        
        public ModificarResponse(ConsumirArqui.webClient.ModificarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ModificarResult;
        
        public ModificarResponseBody() {
        }
        
        public ModificarResponseBody(string ModificarResult) {
            this.ModificarResult = ModificarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Eliminar", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirArqui.webClient.EliminarRequestBody Body;
        
        public EliminarRequest() {
        }
        
        public EliminarRequest(ConsumirArqui.webClient.EliminarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        public EliminarRequestBody() {
        }
        
        public EliminarRequestBody(string email) {
            this.email = email;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirArqui.webClient.EliminarResponseBody Body;
        
        public EliminarResponse() {
        }
        
        public EliminarResponse(ConsumirArqui.webClient.EliminarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EliminarResult;
        
        public EliminarResponseBody() {
        }
        
        public EliminarResponseBody(string EliminarResult) {
            this.EliminarResult = EliminarResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebClienteSoapChannel : ConsumirArqui.webClient.WebClienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebClienteSoapClient : System.ServiceModel.ClientBase<ConsumirArqui.webClient.WebClienteSoap>, ConsumirArqui.webClient.WebClienteSoap {
        
        public WebClienteSoapClient() {
        }
        
        public WebClienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebClienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebClienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebClienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirArqui.webClient.InsertarResponse ConsumirArqui.webClient.WebClienteSoap.Insertar(ConsumirArqui.webClient.InsertarRequest request) {
            return base.Channel.Insertar(request);
        }
        
        public string Insertar(string email, string psw, string nombre, string apellido, string telefono, string categoria) {
            ConsumirArqui.webClient.InsertarRequest inValue = new ConsumirArqui.webClient.InsertarRequest();
            inValue.Body = new ConsumirArqui.webClient.InsertarRequestBody();
            inValue.Body.email = email;
            inValue.Body.psw = psw;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.telefono = telefono;
            inValue.Body.categoria = categoria;
            ConsumirArqui.webClient.InsertarResponse retVal = ((ConsumirArqui.webClient.WebClienteSoap)(this)).Insertar(inValue);
            return retVal.Body.InsertarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirArqui.webClient.InsertarResponse> ConsumirArqui.webClient.WebClienteSoap.InsertarAsync(ConsumirArqui.webClient.InsertarRequest request) {
            return base.Channel.InsertarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirArqui.webClient.InsertarResponse> InsertarAsync(string email, string psw, string nombre, string apellido, string telefono, string categoria) {
            ConsumirArqui.webClient.InsertarRequest inValue = new ConsumirArqui.webClient.InsertarRequest();
            inValue.Body = new ConsumirArqui.webClient.InsertarRequestBody();
            inValue.Body.email = email;
            inValue.Body.psw = psw;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.telefono = telefono;
            inValue.Body.categoria = categoria;
            return ((ConsumirArqui.webClient.WebClienteSoap)(this)).InsertarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirArqui.webClient.ModificarResponse ConsumirArqui.webClient.WebClienteSoap.Modificar(ConsumirArqui.webClient.ModificarRequest request) {
            return base.Channel.Modificar(request);
        }
        
        public string Modificar(string email, string psw, string nombre, string apellido, string telefono, string categoria) {
            ConsumirArqui.webClient.ModificarRequest inValue = new ConsumirArqui.webClient.ModificarRequest();
            inValue.Body = new ConsumirArqui.webClient.ModificarRequestBody();
            inValue.Body.email = email;
            inValue.Body.psw = psw;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.telefono = telefono;
            inValue.Body.categoria = categoria;
            ConsumirArqui.webClient.ModificarResponse retVal = ((ConsumirArqui.webClient.WebClienteSoap)(this)).Modificar(inValue);
            return retVal.Body.ModificarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirArqui.webClient.ModificarResponse> ConsumirArqui.webClient.WebClienteSoap.ModificarAsync(ConsumirArqui.webClient.ModificarRequest request) {
            return base.Channel.ModificarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirArqui.webClient.ModificarResponse> ModificarAsync(string email, string psw, string nombre, string apellido, string telefono, string categoria) {
            ConsumirArqui.webClient.ModificarRequest inValue = new ConsumirArqui.webClient.ModificarRequest();
            inValue.Body = new ConsumirArqui.webClient.ModificarRequestBody();
            inValue.Body.email = email;
            inValue.Body.psw = psw;
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.telefono = telefono;
            inValue.Body.categoria = categoria;
            return ((ConsumirArqui.webClient.WebClienteSoap)(this)).ModificarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirArqui.webClient.EliminarResponse ConsumirArqui.webClient.WebClienteSoap.Eliminar(ConsumirArqui.webClient.EliminarRequest request) {
            return base.Channel.Eliminar(request);
        }
        
        public string Eliminar(string email) {
            ConsumirArqui.webClient.EliminarRequest inValue = new ConsumirArqui.webClient.EliminarRequest();
            inValue.Body = new ConsumirArqui.webClient.EliminarRequestBody();
            inValue.Body.email = email;
            ConsumirArqui.webClient.EliminarResponse retVal = ((ConsumirArqui.webClient.WebClienteSoap)(this)).Eliminar(inValue);
            return retVal.Body.EliminarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirArqui.webClient.EliminarResponse> ConsumirArqui.webClient.WebClienteSoap.EliminarAsync(ConsumirArqui.webClient.EliminarRequest request) {
            return base.Channel.EliminarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirArqui.webClient.EliminarResponse> EliminarAsync(string email) {
            ConsumirArqui.webClient.EliminarRequest inValue = new ConsumirArqui.webClient.EliminarRequest();
            inValue.Body = new ConsumirArqui.webClient.EliminarRequestBody();
            inValue.Body.email = email;
            return ((ConsumirArqui.webClient.WebClienteSoap)(this)).EliminarAsync(inValue);
        }
    }
}
