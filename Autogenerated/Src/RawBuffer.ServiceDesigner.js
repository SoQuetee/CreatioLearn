﻿// jscs:disable
/* jshint ignore:start */
/*ignore jslint start*/
define("RawBuffer",["RawBase64"],function(t){"use strict";const r=2147483647;function e(t){if(t>r)throw new RangeError('The value "'+t+'" is invalid for option "size"');const e=new Uint8Array(t);return e.__proto__=n.prototype,e}function n(t,r,e){if("number"==typeof t){if("string"==typeof r)throw new TypeError('The "string" argument must be of type string. Received type number');return f(t)}return i(t,r,e)}function i(t,r,i){if("string"==typeof t)return function(t,r){"string"==typeof r&&""!==r||(r="utf8");if(!n.isEncoding(r))throw new TypeError("Unknown encoding: "+r);var i=0|h(t,r),o=e(i),f=o.write(t,r);f!==i&&(o=o.slice(0,f));return o}(t,r);if(ArrayBuffer.isView(t))return u(t);if(null==t)throw TypeError("The first argument must be one of type string, Buffer, ArrayBuffer, Array, or Array-like Object. Received type "+typeof t);if(z(t,ArrayBuffer)||t&&z(t.buffer,ArrayBuffer))return function(t,r,e){if(r<0||t.byteLength<r)throw new RangeError('"offset" is outside of buffer bounds');if(t.byteLength<r+(e||0))throw new RangeError('"length" is outside of buffer bounds');var i;i=void 0===r&&void 0===e?new Uint8Array(t):void 0===e?new Uint8Array(t,r):new Uint8Array(t,r,e);return i.__proto__=n.prototype,i}(t,r,i);if("number"==typeof t)throw new TypeError('The "value" argument must not be of type number. Received type number');const o=t.valueOf&&t.valueOf();if(null!=o&&o!==t)return n.from(o,r,i);const f=function(t){if(n.isBuffer(t)){var r=0|s(t.length),i=e(r);return 0===i.length?i:(t.copy(i,0,0,r),i)}if(void 0!==t.length)return"number"!=typeof t.length||D(t.length)?e(0):u(t);if("Buffer"===t.type&&Array.isArray(t.data))return u(t.data)}(t);if(f)return f;if("undefined"!=typeof Symbol&&null!=Symbol.toPrimitive&&"function"==typeof t[Symbol.toPrimitive])return n.from(t[Symbol.toPrimitive]("string"),r,i);throw new TypeError("The first argument must be one of type string, Buffer, ArrayBuffer, Array, or Array-like Object. Received type "+typeof t)}function o(t){if("number"!=typeof t)throw new TypeError('"size" argument must be of type number');if(t<0)throw new RangeError('The value "'+t+'" is invalid for option "size"')}function f(t){return o(t),e(t<0?0:0|s(t))}function u(t){for(var r=t.length<0?0:0|s(t.length),n=e(r),i=0;i<r;i+=1)n[i]=255&t[i];return n}function s(t){if(t>=r)throw new RangeError("Attempt to allocate Buffer larger than maximum size: 0x"+r.toString(16)+" bytes");return 0|t}function h(t,r){if(n.isBuffer(t))return t.length;if(ArrayBuffer.isView(t)||z(t,ArrayBuffer))return t.byteLength;if("string"!=typeof t)throw new TypeError('The "string" argument must be one of type string, Buffer, or ArrayBuffer. Received type '+typeof t);const e=t.length,i=arguments.length>2&&!0===arguments[2];if(!i&&0===e)return 0;let o=!1;for(;;)switch(r){case"ascii":case"latin1":case"binary":return e;case"utf8":case"utf-8":return k(t).length;case"ucs2":case"ucs-2":case"utf16le":case"utf-16le":return 2*e;case"hex":return e>>>1;case"base64":return P(t).length;default:if(o)return i?-1:k(t).length;r=(""+r).toLowerCase(),o=!0}}function a(t,r,e){var n=!1;if((void 0===r||r<0)&&(r=0),r>this.length)return"";if((void 0===e||e>this.length)&&(e=this.length),e<=0)return"";if((e>>>=0)<=(r>>>=0))return"";for(t||(t="utf8");;)switch(t){case"hex":return I(this,r,e);case"utf8":case"utf-8":return E(this,r,e);case"ascii":return A(this,r,e);case"latin1":case"binary":return U(this,r,e);case"base64":return m(this,r,e);case"ucs2":case"ucs-2":case"utf16le":case"utf-16le":return T(this,r,e);default:if(n)throw new TypeError("Unknown encoding: "+t);t=(t+"").toLowerCase(),n=!0}}function p(t,r,e){var n=t[r];t[r]=t[e],t[e]=n}function l(t,r,e,i,o){if(0===t.length)return-1;if("string"==typeof e?(i=e,e=0):e>2147483647?e=2147483647:e<-2147483648&&(e=-2147483648),D(e=+e)&&(e=o?0:t.length-1),e<0&&(e=t.length+e),e>=t.length){if(o)return-1;e=t.length-1}else if(e<0){if(!o)return-1;e=0}if("string"==typeof r&&(r=n.from(r,i)),n.isBuffer(r))return 0===r.length?-1:c(t,r,e,i,o);if("number"==typeof r)return r&=255,"function"==typeof Uint8Array.prototype.indexOf?o?Uint8Array.prototype.indexOf.call(t,r,e):Uint8Array.prototype.lastIndexOf.call(t,r,e):c(t,[r],e,i,o);throw new TypeError("val must be string, number or Buffer")}function c(t,r,e,n,i){var o,f=1,u=t.length,s=r.length;if(void 0!==n&&("ucs2"===(n=String(n).toLowerCase())||"ucs-2"===n||"utf16le"===n||"utf-16le"===n)){if(t.length<2||r.length<2)return-1;f=2,u/=2,s/=2,e/=2}function h(t,r){return 1===f?t[r]:t.readUInt16BE(r*f)}if(i){var a=-1;for(o=e;o<u;o++)if(h(t,o)===h(r,-1===a?0:o-a)){if(-1===a&&(a=o),o-a+1===s)return a*f}else-1!==a&&(o-=o-a),a=-1}else for(e+s>u&&(e=u-s),o=e;o>=0;o--){for(var p=!0,l=0;l<s;l++)if(h(t,o+l)!==h(r,l)){p=!1;break}if(p)return o}return-1}function y(t,r,e,n){e=Number(e)||0;var i=t.length-e;n?(n=Number(n))>i&&(n=i):n=i;var o=r.length;n>o/2&&(n=o/2);for(var f=0;f<n;++f){var u=parseInt(r.substr(2*f,2),16);if(D(u))return f;t[e+f]=u}return f}function g(t,r,e,n){return M(k(r,t.length-e),t,e,n)}function w(t,r,e,n){return M(function(t){for(var r=[],e=0;e<t.length;++e)r.push(255&t.charCodeAt(e));return r}(r),t,e,n)}function d(t,r,e,n){return w(t,r,e,n)}function b(t,r,e,n){return M(P(r),t,e,n)}function v(t,r,e,n){return M(function(t,r){for(var e,n,i,o=[],f=0;f<t.length&&!((r-=2)<0);++f)e=t.charCodeAt(f),n=e>>8,i=e%256,o.push(i),o.push(n);return o}(r,t.length-e),t,e,n)}function m(t,r,e){return 0===r&&e===t.length?fromByteArray(t):fromByteArray(t.slice(r,e))}function E(t,r,e){e=Math.min(t.length,e);for(var n=[],i=r;i<e;){var o,f,u,s,h=t[i],a=null,p=h>239?4:h>223?3:h>191?2:1;if(i+p<=e)switch(p){case 1:h<128&&(a=h);break;case 2:128==(192&(o=t[i+1]))&&(s=(31&h)<<6|63&o)>127&&(a=s);break;case 3:o=t[i+1],f=t[i+2],128==(192&o)&&128==(192&f)&&(s=(15&h)<<12|(63&o)<<6|63&f)>2047&&(s<55296||s>57343)&&(a=s);break;case 4:o=t[i+1],f=t[i+2],u=t[i+3],128==(192&o)&&128==(192&f)&&128==(192&u)&&(s=(15&h)<<18|(63&o)<<12|(63&f)<<6|63&u)>65535&&s<1114112&&(a=s)}null===a?(a=65533,p=1):a>65535&&(a-=65536,n.push(a>>>10&1023|55296),a=56320|1023&a),n.push(a),i+=p}return function(t){var r=t.length;if(r<=B)return String.fromCharCode.apply(String,t);var e="",n=0;for(;n<r;)e+=String.fromCharCode.apply(String,t.slice(n,n+=B));return e}(n)}n.TYPED_ARRAY_SUPPORT=function(){try{const t=new Uint8Array(1);return t.__proto__={__proto__:Uint8Array.prototype,foo:function(){return 42}},42===t.foo()}catch(t){return!1}}(),n.TYPED_ARRAY_SUPPORT||"undefined"==typeof console||"function"!=typeof console.error||console.error("This browser lacks typed array (Uint8Array) support which is required by `buffer` v5.x. Use `buffer` v4.x if you require old browser support."),Object.defineProperty(n.prototype,"parent",{enumerable:!0,get:function(){if(n.isBuffer(this))return this.buffer}}),Object.defineProperty(n.prototype,"offset",{enumerable:!0,get:function(){if(n.isBuffer(this))return this.byteOffset}}),"undefined"!=typeof Symbol&&null!=Symbol.species&&n[Symbol.species]===n&&Object.defineProperty(n,Symbol.species,{value:null,configurable:!0,enumerable:!1,writable:!1}),n.poolSize=8192,n.from=function(t,r,e){return i(t,r,e)},n.prototype.__proto__=Uint8Array.prototype,n.__proto__=Uint8Array,n.alloc=function(t,r,n){return function(t,r,n){return o(t),t<=0?e(t):void 0!==r?"string"==typeof n?e(t).fill(r,n):e(t).fill(r):e(t)}(t,r,n)},n.allocUnsafe=function(t){return f(t)},n.allocUnsafeSlow=function(t){return f(t)},n.isBuffer=function(t){return null!=t&&!0===t._isBuffer&&t!==n.prototype},n.compare=function(t,r){if(z(t,Uint8Array)&&(t=n.from(t,t.offset,t.byteLength)),z(r,Uint8Array)&&(r=n.from(r,r.offset,r.byteLength)),!n.isBuffer(t)||!n.isBuffer(r))throw new TypeError('The "buf1", "buf2" arguments must be one of type Buffer or Uint8Array');if(t===r)return 0;let e=t.length,i=r.length;for(let n=0,o=Math.min(e,i);n<o;++n)if(t[n]!==r[n]){e=t[n],i=r[n];break}return e<i?-1:i<e?1:0},n.isEncoding=function(t){switch(String(t).toLowerCase()){case"hex":case"utf8":case"utf-8":case"ascii":case"latin1":case"binary":case"base64":case"ucs2":case"ucs-2":case"utf16le":case"utf-16le":return!0;default:return!1}},n.concat=function(t,r){if(!Array.isArray(t))throw new TypeError('"list" argument must be an Array of Buffers');if(0===t.length)return n.alloc(0);let e;if(void 0===r)for(r=0,e=0;e<t.length;++e)r+=t[e].length;const i=n.allocUnsafe(r);let o=0;for(e=0;e<t.length;++e){let r=t[e];if(z(r,Uint8Array)&&(r=n.from(r)),!n.isBuffer(r))throw new TypeError('"list" argument must be an Array of Buffers');r.copy(i,o),o+=r.length}return i},n.byteLength=h,n.prototype._isBuffer=!0,n.prototype.slowToString=a,n.prototype.swap16=function(){var t=this.length;if(t%2!=0)throw new RangeError("Buffer size must be a multiple of 16-bits");for(var r=0;r<t;r+=2)p(this,r,r+1);return this},n.prototype.swap32=function(){var t=this.length;if(t%4!=0)throw new RangeError("Buffer size must be a multiple of 32-bits");for(var r=0;r<t;r+=4)p(this,r,r+3),p(this,r+1,r+2);return this},n.prototype.swap64=function(){var t=this.length;if(t%8!=0)throw new RangeError("Buffer size must be a multiple of 64-bits");for(var r=0;r<t;r+=8)p(this,r,r+7),p(this,r+1,r+6),p(this,r+2,r+5),p(this,r+3,r+4);return this},n.prototype.toString=function(){var t=this.length;return 0===t?"":0===arguments.length?E(this,0,t):a.apply(this,arguments)},n.prototype.toLocaleString=n.prototype.toString,n.prototype.equals=function(t){if(!n.isBuffer(t))throw new TypeError("Argument must be a Buffer");return this===t||0===n.compare(this,t)},n.prototype.inspect=function(){var t="";return t=this.toString("hex",0,50).replace(/(.{2})/g,"$1 ").trim(),this.length>50&&(t+=" ... "),"<Buffer "+t+">"},n.prototype.compare=function(t,r,e,i,o){if(z(t,Uint8Array)&&(t=n.from(t,t.offset,t.byteLength)),!n.isBuffer(t))throw new TypeError('The "target" argument must be one of type Buffer or Uint8Array. Received type '+typeof t);if(void 0===r&&(r=0),void 0===e&&(e=t?t.length:0),void 0===i&&(i=0),void 0===o&&(o=this.length),r<0||e>t.length||i<0||o>this.length)throw new RangeError("out of range index");if(i>=o&&r>=e)return 0;if(i>=o)return-1;if(r>=e)return 1;if(this===t)return 0;for(var f=(o>>>=0)-(i>>>=0),u=(e>>>=0)-(r>>>=0),s=Math.min(f,u),h=this.slice(i,o),a=t.slice(r,e),p=0;p<s;++p)if(h[p]!==a[p]){f=h[p],u=a[p];break}return f<u?-1:u<f?1:0},n.prototype.includes=function(t,r,e){return-1!==this.indexOf(t,r,e)},n.prototype.indexOf=function(t,r,e){return l(this,t,r,e,!0)},n.prototype.lastIndexOf=function(t,r,e){return l(this,t,r,e,!1)},n.prototype.write=function(t,r,e,n){if(void 0===r)n="utf8",e=this.length,r=0;else if(void 0===e&&"string"==typeof r)n=r,e=this.length,r=0;else{if(!isFinite(r))throw new Error("Buffer.write(string, encoding, offset[, length]) is no longer supported");r>>>=0,isFinite(e)?(e>>>=0,void 0===n&&(n="utf8")):(n=e,e=void 0)}var i=this.length-r;if((void 0===e||e>i)&&(e=i),t.length>0&&(e<0||r<0)||r>this.length)throw new RangeError("Attempt to write outside buffer bounds");n||(n="utf8");for(var o=!1;;)switch(n){case"hex":return y(this,t,r,e);case"utf8":case"utf-8":return g(this,t,r,e);case"ascii":return w(this,t,r,e);case"latin1":case"binary":return d(this,t,r,e);case"base64":return b(this,t,r,e);case"ucs2":case"ucs-2":case"utf16le":case"utf-16le":return v(this,t,r,e);default:if(o)throw new TypeError("Unknown encoding: "+n);n=(""+n).toLowerCase(),o=!0}},n.prototype.toJSON=function(){return{type:"Buffer",data:Array.prototype.slice.call(this._arr||this,0)}};var B=4096;function A(t,r,e){var n="";e=Math.min(t.length,e);for(var i=r;i<e;++i)n+=String.fromCharCode(127&t[i]);return n}function U(t,r,e){var n="";e=Math.min(t.length,e);for(var i=r;i<e;++i)n+=String.fromCharCode(t[i]);return n}function I(t,r,e){var n=t.length;(!r||r<0)&&(r=0),(!e||e<0||e>n)&&(e=n);for(var i="",o=r;o<e;++o)i+=O(t[o]);return i}function T(t,r,e){for(var n=t.slice(r,e),i="",o=0;o<n.length;o+=2)i+=String.fromCharCode(n[o]+256*n[o+1]);return i}function _(t,r,e){if(t%1!=0||t<0)throw new RangeError("offset is not uint");if(t+r>e)throw new RangeError("Trying to access beyond buffer length")}function R(t,r,e,i,o,f){if(!n.isBuffer(t))throw new TypeError('"buffer" argument must be a Buffer instance');if(r>o||r<f)throw new RangeError('"value" argument is out of bounds');if(e+i>t.length)throw new RangeError("Index out of range")}function S(t,r,e,n,i,o){if(e+n>t.length)throw new RangeError("Index out of range");if(e<0)throw new RangeError("Index out of range")}function L(t,r,e,n,i){return r=+r,e>>>=0,i||S(t,0,e,4),ieee754.write(t,r,e,n,23,4),e+4}function x(t,r,e,n,i){return r=+r,e>>>=0,i||S(t,0,e,8),ieee754.write(t,r,e,n,52,8),e+8}n.prototype.slice=function(t,r){var e=this.length;(t=~~t)<0?(t+=e)<0&&(t=0):t>e&&(t=e),(r=void 0===r?e:~~r)<0?(r+=e)<0&&(r=0):r>e&&(r=e),r<t&&(r=t);var i=this.subarray(t,r);return i.__proto__=n.prototype,i},n.prototype.readUIntLE=function(t,r,e){t>>>=0,r>>>=0,e||_(t,r,this.length);for(var n=this[t],i=1,o=0;++o<r&&(i*=256);)n+=this[t+o]*i;return n},n.prototype.readUIntBE=function(t,r,e){t>>>=0,r>>>=0,e||_(t,r,this.length);for(var n=this[t+--r],i=1;r>0&&(i*=256);)n+=this[t+--r]*i;return n},n.prototype.readUInt8=function(t,r){return t>>>=0,r||_(t,1,this.length),this[t]},n.prototype.readUInt16LE=function(t,r){return t>>>=0,r||_(t,2,this.length),this[t]|this[t+1]<<8},n.prototype.readUInt16BE=function(t,r){return t>>>=0,r||_(t,2,this.length),this[t]<<8|this[t+1]},n.prototype.readUInt32LE=function(t,r){return t>>>=0,r||_(t,4,this.length),(this[t]|this[t+1]<<8|this[t+2]<<16)+16777216*this[t+3]},n.prototype.readUInt32BE=function(t,r){return t>>>=0,r||_(t,4,this.length),16777216*this[t]+(this[t+1]<<16|this[t+2]<<8|this[t+3])},n.prototype.readIntLE=function(t,r,e){t>>>=0,r>>>=0,e||_(t,r,this.length);for(var n=this[t],i=1,o=0;++o<r&&(i*=256);)n+=this[t+o]*i;return n>=(i*=128)&&(n-=Math.pow(2,8*r)),n},n.prototype.readIntBE=function(t,r,e){t>>>=0,r>>>=0,e||_(t,r,this.length);for(var n=r,i=1,o=this[t+--n];n>0&&(i*=256);)o+=this[t+--n]*i;return o>=(i*=128)&&(o-=Math.pow(2,8*r)),o},n.prototype.readInt8=function(t,r){return t>>>=0,r||_(t,1,this.length),128&this[t]?-1*(255-this[t]+1):this[t]},n.prototype.readInt16LE=function(t,r){t>>>=0,r||_(t,2,this.length);var e=this[t]|this[t+1]<<8;return 32768&e?4294901760|e:e},n.prototype.readInt16BE=function(t,r){t>>>=0,r||_(t,2,this.length);var e=this[t+1]|this[t]<<8;return 32768&e?4294901760|e:e},n.prototype.readInt32LE=function(t,r){return t>>>=0,r||_(t,4,this.length),this[t]|this[t+1]<<8|this[t+2]<<16|this[t+3]<<24},n.prototype.readInt32BE=function(t,r){return t>>>=0,r||_(t,4,this.length),this[t]<<24|this[t+1]<<16|this[t+2]<<8|this[t+3]},n.prototype.readFloatLE=function(t,r){return t>>>=0,r||_(t,4,this.length),ieee754.read(this,t,!0,23,4)},n.prototype.readFloatBE=function(t,r){return t>>>=0,r||_(t,4,this.length),ieee754.read(this,t,!1,23,4)},n.prototype.readDoubleLE=function(t,r){return t>>>=0,r||_(t,8,this.length),ieee754.read(this,t,!0,52,8)},n.prototype.readDoubleBE=function(t,r){return t>>>=0,r||_(t,8,this.length),ieee754.read(this,t,!1,52,8)},n.prototype.writeUIntLE=function(t,r,e,n){(t=+t,r>>>=0,e>>>=0,n)||R(this,t,r,e,Math.pow(2,8*e)-1,0);var i=1,o=0;for(this[r]=255&t;++o<e&&(i*=256);)this[r+o]=t/i&255;return r+e},n.prototype.writeUIntBE=function(t,r,e,n){(t=+t,r>>>=0,e>>>=0,n)||R(this,t,r,e,Math.pow(2,8*e)-1,0);var i=e-1,o=1;for(this[r+i]=255&t;--i>=0&&(o*=256);)this[r+i]=t/o&255;return r+e},n.prototype.writeUInt8=function(t,r,e){return t=+t,r>>>=0,e||R(this,t,r,1,255,0),this[r]=255&t,r+1},n.prototype.writeUInt16LE=function(t,r,e){return t=+t,r>>>=0,e||R(this,t,r,2,65535,0),this[r]=255&t,this[r+1]=t>>>8,r+2},n.prototype.writeUInt16BE=function(t,r,e){return t=+t,r>>>=0,e||R(this,t,r,2,65535,0),this[r]=t>>>8,this[r+1]=255&t,r+2},n.prototype.writeUInt32LE=function(t,r,e){return t=+t,r>>>=0,e||R(this,t,r,4,4294967295,0),this[r+3]=t>>>24,this[r+2]=t>>>16,this[r+1]=t>>>8,this[r]=255&t,r+4},n.prototype.writeUInt32BE=function(t,r,e){return t=+t,r>>>=0,e||R(this,t,r,4,4294967295,0),this[r]=t>>>24,this[r+1]=t>>>16,this[r+2]=t>>>8,this[r+3]=255&t,r+4},n.prototype.writeIntLE=function(t,r,e,n){if(t=+t,r>>>=0,!n){var i=Math.pow(2,8*e-1);R(this,t,r,e,i-1,-i)}var o=0,f=1,u=0;for(this[r]=255&t;++o<e&&(f*=256);)t<0&&0===u&&0!==this[r+o-1]&&(u=1),this[r+o]=(t/f>>0)-u&255;return r+e},n.prototype.writeIntBE=function(t,r,e,n){if(t=+t,r>>>=0,!n){var i=Math.pow(2,8*e-1);R(this,t,r,e,i-1,-i)}var o=e-1,f=1,u=0;for(this[r+o]=255&t;--o>=0&&(f*=256);)t<0&&0===u&&0!==this[r+o+1]&&(u=1),this[r+o]=(t/f>>0)-u&255;return r+e},n.prototype.writeInt8=function(t,r,e){return t=+t,r>>>=0,e||R(this,t,r,1,127,-128),t<0&&(t=255+t+1),this[r]=255&t,r+1},n.prototype.writeInt16LE=function(t,r,e){return t=+t,r>>>=0,e||R(this,t,r,2,32767,-32768),this[r]=255&t,this[r+1]=t>>>8,r+2},n.prototype.writeInt16BE=function(t,r,e){return t=+t,r>>>=0,e||R(this,t,r,2,32767,-32768),this[r]=t>>>8,this[r+1]=255&t,r+2},n.prototype.writeInt32LE=function(t,r,e){return t=+t,r>>>=0,e||R(this,t,r,4,2147483647,-2147483648),this[r]=255&t,this[r+1]=t>>>8,this[r+2]=t>>>16,this[r+3]=t>>>24,r+4},n.prototype.writeInt32BE=function(t,r,e){return t=+t,r>>>=0,e||R(this,t,r,4,2147483647,-2147483648),t<0&&(t=4294967295+t+1),this[r]=t>>>24,this[r+1]=t>>>16,this[r+2]=t>>>8,this[r+3]=255&t,r+4},n.prototype.writeFloatLE=function(t,r,e){return L(this,t,r,!0,e)},n.prototype.writeFloatBE=function(t,r,e){return L(this,t,r,!1,e)},n.prototype.writeDoubleLE=function(t,r,e){return x(this,t,r,!0,e)},n.prototype.writeDoubleBE=function(t,r,e){return x(this,t,r,!1,e)},n.prototype.copy=function(t,r,e,i){if(!n.isBuffer(t))throw new TypeError("argument should be a Buffer");if(e||(e=0),i||0===i||(i=this.length),r>=t.length&&(r=t.length),r||(r=0),i>0&&i<e&&(i=e),i===e)return 0;if(0===t.length||0===this.length)return 0;if(r<0)throw new RangeError("targetStart out of bounds");if(e<0||e>=this.length)throw new RangeError("Index out of range");if(i<0)throw new RangeError("sourceEnd out of bounds");i>this.length&&(i=this.length),t.length-r<i-e&&(i=t.length-r+e);var o=i-e;if(this===t&&"function"==typeof Uint8Array.prototype.copyWithin)this.copyWithin(r,e,i);else if(this===t&&e<r&&r<i)for(var f=o-1;f>=0;--f)t[f+r]=this[f+e];else Uint8Array.prototype.set.call(t,this.subarray(e,i),r);return o},n.prototype.fill=function(t,r,e,i){if("string"==typeof t){if("string"==typeof r?(i=r,r=0,e=this.length):"string"==typeof e&&(i=e,e=this.length),void 0!==i&&"string"!=typeof i)throw new TypeError("encoding must be a string");if("string"==typeof i&&!n.isEncoding(i))throw new TypeError("Unknown encoding: "+i);if(1===t.length){var o=t.charCodeAt(0);("utf8"===i&&o<128||"latin1"===i)&&(t=o)}}else"number"==typeof t&&(t&=255);if(r<0||this.length<r||this.length<e)throw new RangeError("Out of range index");if(e<=r)return this;var f;if(r>>>=0,e=void 0===e?this.length:e>>>0,t||(t=0),"number"==typeof t)for(f=r;f<e;++f)this[f]=t;else{var u=n.isBuffer(t)?t:n.from(t,i),s=u.length;if(0===s)throw new TypeError('The value "'+t+'" is invalid for argument "value"');for(f=0;f<e-r;++f)this[f+r]=u[f%s]}return this};var C=/[^+/0-9A-Za-z-_]/g;function O(t){return t<16?"0"+t.toString(16):t.toString(16)}function k(t,r){var e;r=r||1/0;for(var n=t.length,i=null,o=[],f=0;f<n;++f){if((e=t.charCodeAt(f))>55295&&e<57344){if(!i){if(e>56319){(r-=3)>-1&&o.push(239,191,189);continue}if(f+1===n){(r-=3)>-1&&o.push(239,191,189);continue}i=e;continue}if(e<56320){(r-=3)>-1&&o.push(239,191,189),i=e;continue}e=65536+(i-55296<<10|e-56320)}else i&&(r-=3)>-1&&o.push(239,191,189);if(i=null,e<128){if((r-=1)<0)break;o.push(e)}else if(e<2048){if((r-=2)<0)break;o.push(e>>6|192,63&e|128)}else if(e<65536){if((r-=3)<0)break;o.push(e>>12|224,e>>6&63|128,63&e|128)}else{if(!(e<1114112))throw new Error("Invalid code point");if((r-=4)<0)break;o.push(e>>18|240,e>>12&63|128,e>>6&63|128,63&e|128)}}return o}function P(r){return t.toByteArray(function(t){if((t=(t=t.split("=")[0]).trim().replace(C,"")).length<2)return"";for(;t.length%4!=0;)t+="=";return t}(r))}function M(t,r,e,n){for(var i=0;i<n&&!(i+e>=r.length||i>=t.length);++i)r[i+e]=t[i];return i}function z(t,r){return t instanceof r||null!=t&&null!=t.constructor&&null!=t.constructor.name&&t.constructor.name===r.name}function D(t){return t!=t}return n});