(function(){var aa=function(a,b,c){return a.call.apply(a.bind,arguments)},ba=function(a,b,c){if(!a)throw Error();if(2<arguments.length){var d=Array.prototype.slice.call(arguments,2);return function(){var c=Array.prototype.slice.call(arguments);Array.prototype.unshift.apply(c,d);return a.apply(b,c)}}return function(){return a.apply(b,arguments)}},n=function(a,b,c){n=Function.prototype.bind&&-1!=Function.prototype.bind.toString().indexOf("native code")?aa:ba;return n.apply(null,arguments)};var p=(new Date).getTime();var u=function(a){a=parseFloat(a);return isNaN(a)||1<a||0>a?0:a},ca=/^([\w-]+\.)*([\w-]{2,})(\:[0-9]+)?$/,x=function(a,b){if(!a)return b;var c=a.match(ca);return c?c[0]:b};var A=function(){return x("","pagead2.googlesyndication.com")};var da=/&/g,ea=/</g,fa=/>/g,ga=/\"/g,B={"\x00":"\\0","\b":"\\b","\f":"\\f","\n":"\\n","\r":"\\r","\t":"\\t","\x0B":"\\x0B",'"':'\\"',"\\":"\\\\"},C={"'":"\\'"};var ha=window;A();var D=function(a,b){for(var c in a)Object.prototype.hasOwnProperty.call(a,c)&&b.call(null,a[c],c,a)},E=function(a){return!!a&&"function"==typeof a&&!!a.call},F=function(a,b){if(!(2>arguments.length))for(var c=1,d=arguments.length;c<d;++c)a.push(arguments[c])},G=function(a,b){if(!(1E-4>Math.random())){var c=Math.random();if(c<b)return a[Math.floor(c/b*a.length)]}return null},H=function(a){try{return!!a.location.href||""===a.location.href}catch(b){return!1}};var ia=u("0"),ja=u("0"),ka=u("");var la=/^true$/.test("false")?!0:!1;var I=null,J=function(){if(!I){for(var a=window,b=a,c=0;a!=a.parent;)if(a=a.parent,c++,H(a))b=a;else break;I=b}return I};var K,L=function(a){this.c=[];this.b=a||window;this.a=0;this.d=null},M=function(a,b){this.l=a;this.i=b};L.prototype.n=function(a,b){0!=this.a||0!=this.c.length||b&&b!=window?this.g(a,b):(this.a=2,this.f(new M(a,window)))};L.prototype.g=function(a,b){this.c.push(new M(a,b||this.b));N(this)};L.prototype.o=function(a){this.a=1;a&&(this.d=this.b.setTimeout(n(this.e,this),a))};L.prototype.e=function(){1==this.a&&(null!=this.d&&(this.b.clearTimeout(this.d),this.d=null),this.a=0);N(this)};
L.prototype.p=function(){return!0};L.prototype.nq=L.prototype.n;L.prototype.nqa=L.prototype.g;L.prototype.al=L.prototype.o;L.prototype.rl=L.prototype.e;L.prototype.sz=L.prototype.p;var N=function(a){a.b.setTimeout(n(a.m,a),0)};L.prototype.m=function(){if(0==this.a&&this.c.length){var a=this.c.shift();this.a=2;a.i.setTimeout(n(this.f,this,a),0);N(this)}};L.prototype.f=function(a){this.a=0;a.l()};
var O=function(a){try{return a.sz()}catch(b){return!1}},P=function(a){return!!a&&("object"==typeof a||"function"==typeof a)&&O(a)&&E(a.nq)&&E(a.nqa)&&E(a.al)&&E(a.rl)},Q=function(){if(K&&O(K))return K;var a=J(),b=a.google_jobrunner;return P(b)?K=b:a.google_jobrunner=K=new L(a)},ma=function(a,b){Q().nq(a,b)},na=function(a,b){Q().nqa(a,b)};var R=function(a,b,c){c||(c=la?"https":"http");return[c,"://",a,b].join("")};var oa=function(){},S=function(a,b,c){switch(typeof b){case "string":pa(b,c);break;case "number":c.push(isFinite(b)&&!isNaN(b)?b:"null");break;case "boolean":c.push(b);break;case "undefined":c.push("null");break;case "object":if(null==b){c.push("null");break}if(b instanceof Array){var d=b.length;c.push("[");for(var g="",e=0;e<d;e++)c.push(g),S(a,b[e],c),g=",";c.push("]");break}c.push("{");d="";for(g in b)b.hasOwnProperty(g)&&(e=b[g],"function"!=typeof e&&(c.push(d),pa(g,c),c.push(":"),S(a,e,c),d=
","));c.push("}");break;case "function":break;default:throw Error("Unknown type: "+typeof b);}},T={'"':'\\"',"\\":"\\\\","/":"\\/","\b":"\\b","\f":"\\f","\n":"\\n","\r":"\\r","\t":"\\t","\x0B":"\\u000b"},qa=/\uffff/.test("\uffff")?/[\\\"\x00-\x1f\x7f-\uffff]/g:/[\\\"\x00-\x1f\x7f-\xff]/g,pa=function(a,b){b.push('"');b.push(a.replace(qa,function(a){if(a in T)return T[a];var b=a.charCodeAt(0),g="\\u";16>b?g+="000":256>b?g+="00":4096>b&&(g+="0");return T[a]=g+b.toString(16)}));b.push('"')};var ra=function(a){a.google_page_url&&(a.google_page_url=String(a.google_page_url));var b=[];D(a,function(a,d){if(null!=a){var g;try{var e=[];S(new oa,a,e);g=e.join("")}catch(k){}g&&F(b,d,"=",g,";")}});return b.join("")};var sa=/\.((google(|groups|mail|images|print))|gmail)\./,ta=function(a){var b=sa.test(a.location.host);return!(!a.postMessage||!a.localStorage||!a.JSON||b)};var U=function(a){this.b=a;a.google_iframe_oncopy||(a.google_iframe_oncopy={handlers:{}});this.j=a.google_iframe_oncopy},ua;var V="var i=this.id,s=window.google_iframe_oncopy,H=s&&s.handlers,h=H&&H[i],w=this.contentWindow,d;try{d=w.document}catch(e){}if(h&&d&&(!d.body||!d.body.firstChild)){if(h.call){setTimeout(h,0)}else if(h.match){w.location.replace(h)}}";
/[&<>\"]/.test(V)&&(-1!=V.indexOf("&")&&(V=V.replace(da,"&amp;")),-1!=V.indexOf("<")&&(V=V.replace(ea,"&lt;")),-1!=V.indexOf(">")&&(V=V.replace(fa,"&gt;")),-1!=V.indexOf('"')&&(V=V.replace(ga,"&quot;")));ua=V;U.prototype.set=function(a,b){this.j.handlers[a]=b;this.b.addEventListener&&!/MSIE/.test(navigator.userAgent)&&this.b.addEventListener("load",n(this.k,this,a),!1)};U.prototype.k=function(a){a=this.b.document.getElementById(a);var b=a.contentWindow.document;if(a.onload&&b&&(!b.body||!b.body.firstChild))a.onload()};var va=function(){var a="script";return["<",a,' src="',R(A(),"/pagead/js/r20130606/r20130206/show_ads_impl.js",""),'"></',a,">"].join("")},wa=function(a,b,c,d){return function(){var g=!1;d&&Q().al(3E4);try{if(H(a.document.getElementById(b).contentWindow)){var e=a.document.getElementById(b).contentWindow,k=e.document;k.body&&k.body.firstChild||(k.open(),
e.google_async_iframe_close=!0,k.write(c))}else{var m=a.document.getElementById(b).contentWindow,f;e=c;e=String(e);if(e.quote)f=e.quote();else{for(var k=['"'],h=0;h<e.length;h++){var l=e.charAt(h),y=l.charCodeAt(0),v=k,w=h+1,s;if(!(s=B[l])){var z;if(31<y&&127>y)z=l;else{var r=l;if(r in C)z=C[r];else if(r in B)z=C[r]=B[r];else{var q=r,t=r.charCodeAt(0);if(31<t&&127>t)q=r;else{if(256>t){if(q="\\x",16>t||256<t)q+="0"}else q="\\u",4096>t&&(q+="0");q+=t.toString(16).toUpperCase()}z=C[r]=q}}s=z}v[w]=s}k.push('"');
f=k.join("")}m.location.replace("javascript:"+f)}g=!0}catch(Ka){m=J().google_jobrunner,P(m)&&m.rl()}g&&(new U(a)).set(b,wa(a,b,c,!1))}},xa=function(a){var b=["<iframe"];D(a,function(a,d){b.push(" "+d+'="'+(null==a?"":a)+'"')});b.push("></iframe>");return b.join("")},ya=function(a,b,c,d){d=d?'"':"";var g=d+"0"+d;a.width=d+b+d;a.height=d+c+d;a.frameborder=g;a.marginwidth=g;a.marginheight=g;a.vspace=g;a.hspace=g;a.allowtransparency=d+"true"+d;a.scrolling=d+"no"+d},Aa=function(a,b,c){za(a,b,c,function(a,
b,e){for(var k=b.id,m=0;!k||a.document.getElementById(k);)k="aswift_"+m++;b.id=k;b.name=k;a=Number(e.google_ad_width);k=Number(e.google_ad_height);e=["<iframe"];for(var f in b)b.hasOwnProperty(f)&&F(e,f+"="+b[f]);e.push('style="left:0;position:absolute;top:0;"');e.push("></iframe>");f="border:none;height:"+k+"px;margin:0;padding:0;position:relative;visibility:visible;width:"+a+"px";c.innerHTML=['<ins style="display:inline-table;',f,'"><ins id="',b.id+"_anchor",'" style="display:block;',f,'">',e.join(" "),
"</ins></ins>"].join("");return b.id})},za=function(a,b,c,d){var g="script",e=b.google_ad_width,k=b.google_ad_height,m={};ya(m,e,k,!0);m.onload='"'+ua+'"';d=d(a,m,b);var m=ra(b),f=b.google_ad_output,h=b.google_ad_format;h||"html"!=f&&null!=f||(h=b.google_ad_width+"x"+b.google_ad_height);f=!b.google_ad_slot||b.google_override_format||"aa"==b.google_loader_used;h=h&&f?h.toLowerCase():"";b.google_ad_format=h;h=b||ha;h=[h.google_ad_slot,h.google_ad_format,h.google_ad_type,h.google_ad_width,h.google_ad_height];
if(c){if(c){for(var f=[],l=0;c&&25>l;c=c.parentNode,++l)f.push(9!=c.nodeType&&c.id||"");c=f.join()}else c="";c&&h.push(c)}c=0;if(h)if(c=h.join(":"),h=c.length,0==h)c=0;else{f=305419896;for(l=0;l<h;l++)f^=(f<<5)+(f>>2)+c.charCodeAt(l)&4294967295;c=0<f?f:4294967296+f}c=c.toString();i:{h=a.google_async_slots;h||(h=a.google_async_slots={});f=a.google_unique_id;f=String("number"==typeof f?f:0);if(f in h&&(f+="b",f in h))break i;h[f]={sent:!1,w:b.google_ad_width||"",h:b.google_ad_height||"",adk:c,type:b.google_ad_type||
"",slot:b.google_ad_slot||"",fmt:b.google_ad_format||"",cli:b.google_ad_client||"",saw:[]}}ta(a)&&void 0===a.google_ad_handling_experiment&&(a.google_ad_handling_experiment=G(["XN"],ja)||G(["PC"],ka));h=a.google_ad_handling_experiment?String(a.google_ad_handling_experiment):null;if(ta(a)&&1==a.google_unique_id&&"XN"!=h){f="zrt_ads_frame"+a.google_unique_id;b=b.google_page_url;if(!b){t:{b=a.document;var l=e||a.google_ad_width,y=k||a.google_ad_height;if(a.top==a)b=!1;else{var v=b.documentElement;if(l&&
y){var w=1,s=1;a.innerHeight?(w=a.innerWidth,s=a.innerHeight):v&&v.clientHeight?(w=v.clientWidth,s=v.clientHeight):b.body&&(w=b.body.clientWidth,s=b.body.clientHeight);if(s>2*y||w>2*l){b=!1;break t}}b=!0}}b=b?a.document.referrer:a.document.URL}l=encodeURIComponent(b);b=null;"PC"==h&&(b="K-"+(l+"/"+c+"/"+a.google_unique_id));l={};ya(l,e,k,!1);l.style="display:none";e=b;l.id=f;l.name=f;l.src=R(x("","googleads.g.doubleclick.net"),["/pagead/html/r20130606/r20130206/zrt_lookup.html",
e?"#"+encodeURIComponent(e):""].join(""));e=xa(l)}else e=null;k=(new Date).getTime();b=a.google_top_experiment;f=a.google_async_for_oa_experiment;m=["<!doctype html><html><body>",e,"<",g,">",m,"google_show_ads_impl=true;google_unique_id=",a.google_unique_id,';google_async_iframe_id="',d,'";google_ad_unit_key="',c,'";google_start_time=',p,";",b?'google_top_experiment="'+b+'";':"",h?'google_ad_handling_experiment="'+h+'";':"",f?'google_async_for_oa_experiment="'+f+'";':"","google_bpp=",k>p?k-p:1,";</",
g,">",va(),"</body></html>"].join("");(a.document.getElementById(d)?ma:na)(wa(a,d,m,!0))},Ba=Math.floor(1E6*Math.random()),Ca=function(a){for(var b=a.data.split("\n"),c={},d=0;d<b.length;d++){var g=b[d].indexOf("=");-1!=g&&(c[b[d].substr(0,g)]=b[d].substr(g+1))}b=c[3];if(c[1]==Ba&&(window.google_top_js_status=4,a.source==top&&0==b.indexOf(a.origin)&&(window.google_top_values=c,window.google_top_js_status=5),window.google_top_js_callbacks)){for(a=0;a<window.google_top_js_callbacks.length;a++)window.google_top_js_callbacks[a]();
window.google_top_js_callbacks.length=0}};var Da=function(a){return/(^| )adsbygoogle($| )/.test(a.className)&&"done"!=a.getAttribute("data-adsbygoogle-status")},Ea=function(a){for(var b=document.getElementsByTagName("ins"),c=0,d=b[c];c<b.length;d=b[++c])if(Da(d)&&(!a||d.id==a))return d;return null},Fa=function(a){var b=a.element;a=a.params||{};if(b){if(!Da(b)&&(b=b.id&&Ea(b.id),!b))throw Error("adsbygoogle:'element' has already been filled.");if(!("innerHTML"in b))throw Error("adsbygoogle.push():'element' is not a good DOM element.");}else if(b=
Ea(),!b)throw Error("adsbygoogle.push():No unfilled adsense blocks left!");b.setAttribute("data-adsbygoogle-status","done");var c=window;c.google_unique_id?++c.google_unique_id:c.google_unique_id=1;for(var d=b.attributes,g=d.length,e=0;e<g;e++){var k=d[e];if(/data-/.test(k.nodeName)){var m=k.nodeName.replace("data","google").replace(/-/g,"_");a.hasOwnProperty(m)||(a[m]=k.nodeValue)}}d=["width","height"];for(e=0;e<d.length;e++)m="google_ad_"+d[e],a.hasOwnProperty(m)||(g=/([0-9]+)px/.exec(b.style[d[e]]))&&
(a[m]=g[1]);a.google_loader_used="aa";if((e=a.google_ad_output)&&"html"!=e)throw Error("No support for google_ad_output="+e);Aa(c,a,b)};
if(!window.google_top_experiment){var W=window;if(2!==(W.top==W?0:H(W.top)?1:2))window.google_top_js_status=0;else if(top.postMessage){var X;try{X=top.frames.google_top_static_frame?!0:!1}catch(Ga){X=!1}if(X){if(window.google_top_experiment=G(["jp_c","jp_zl"],ia)||"jp_wfpmr","jp_zl"===window.google_top_experiment||"jp_wfpmr"===window.google_top_experiment){var Y=window;Y.addEventListener?Y.addEventListener("message",Ca,!1):Y.attachEvent&&Y.attachEvent("onmessage",Ca);window.google_top_js_status=3;
var Ha={0:"google_loc_request",1:Ba},Ia=[],Z;for(Z in Ha)Ia.push(Z+"="+Ha[Z]);top.postMessage(Ia.join("\n"),"*")}}else window.google_top_js_status=2}else window.google_top_js_status=1}var $=window.adsbygoogle;if($&&$.shift)for(var Ja,La=20;(Ja=$.shift())&&0<La--;)Fa(Ja);window.adsbygoogle={push:Fa};})();