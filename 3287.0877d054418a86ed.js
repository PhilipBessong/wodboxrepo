"use strict";(self.webpackChunkapp=self.webpackChunkapp||[]).push([[3287],{3287:(ne,N,h)=>{h.r(N),h.d(N,{startInputShims:()=>oe});var j,F,M=h(5861),x=h(8360),m=h(839),W=h(7484);h(4874),h(6225);const p=new WeakMap,B=(e,t,s,o=0,n=!1)=>{p.has(e)!==s&&(s?z(e,t,o,n):V(e,t))},z=(e,t,s,o=!1)=>{const n=t.parentNode,a=t.cloneNode(!1);a.classList.add("cloned-input"),a.tabIndex=-1,o&&(a.disabled=!0),n.appendChild(a),p.set(e,a);const r="rtl"===e.ownerDocument.dir?9999:-9999;e.style.pointerEvents="none",t.style.transform=`translate3d(${r}px,${s}px,0) scale(0)`},V=(e,t)=>{const s=p.get(e);s&&(p.delete(e),s.remove()),e.style.pointerEvents="",t.style.transform=""},O="input, textarea, [no-blur], [contenteditable]",H="$ionPaddingTimer",K=(e,t,s)=>{const o=e[H];o&&clearTimeout(o),t>0?e.style.setProperty("--keyboard-offset",`${t}px`):e[H]=setTimeout(()=>{e.style.setProperty("--keyboard-offset","0px"),s&&s()},120)},Z=(e,t,s)=>{e.addEventListener("focusout",()=>{t&&K(t,0,s)},{once:!0})};let P=0;const R="data-ionic-skip-scroll-assist",ee=(e,t,s,o,n,a,c,r=!1)=>{var i;const d=a&&(void 0===c||c.mode===W.a.None),l=function(){return(i=i||(0,M.Z)(function*(){t.hasAttribute(R)?t.removeAttribute(R):te(e,t,s,o,n,d,r)})).apply(this,arguments)};return e.addEventListener("focusin",l,!0),()=>{e.removeEventListener("focusin",l,!0)}},U=e=>{document.activeElement!==e&&(e.setAttribute(R,"true"),e.focus())},te=function(t,s,o,n,a,c){return(j=j||(0,M.Z)(function*(r,i,d,l,y,g,L=!1){if(!d&&!l)return;const f=((e,t,s)=>{var o;return((e,t,s,o)=>{const n=e.top,a=e.bottom,c=t.top,i=c+15,l=Math.min(t.bottom,o-s)-50-a,y=i-n,g=Math.round(l<0?-l:y>0?-y:0),L=Math.min(g,n-c),v=Math.abs(L)/.3;return{scrollAmount:L,scrollDuration:Math.min(400,Math.max(150,v)),scrollPadding:s,inputSafeY:4-(n-i)}})((null!==(o=e.closest("ion-item,[ion-item]"))&&void 0!==o?o:e).getBoundingClientRect(),t.getBoundingClientRect(),s,e.ownerDocument.defaultView.innerHeight)})(r,d||l,y);if(d&&Math.abs(f.scrollAmount)<4)return U(i),void(g&&null!==d&&(K(d,P),Z(i,d,()=>P=0)));if(B(r,i,!0,f.inputSafeY,L),U(i),(0,m.r)(()=>r.click()),g&&d&&(P=f.scrollPadding,K(d,P)),typeof window<"u"){var v;let S;const b=function D(){return(v=v||(0,M.Z)(function*(){void 0!==S&&clearTimeout(S),window.removeEventListener("ionKeyboardDidShow",A),window.removeEventListener("ionKeyboardDidShow",D),d&&(yield(0,x.c)(d,0,f.scrollAmount,f.scrollDuration)),B(r,i,!1,f.inputSafeY),U(i),g&&Z(i,d,()=>P=0)})).apply(this,arguments)},A=()=>{window.removeEventListener("ionKeyboardDidShow",A),window.addEventListener("ionKeyboardDidShow",b)};if(d){const D=yield(0,x.g)(d);if(f.scrollAmount>D.scrollHeight-D.clientHeight-D.scrollTop)return"password"===i.type?(f.scrollAmount+=50,window.addEventListener("ionKeyboardDidShow",A)):window.addEventListener("ionKeyboardDidShow",b),void(S=setTimeout(b,1e3))}b()}})).apply(this,arguments)},oe=function(t,s){return(F=F||(0,M.Z)(function*(o,n){var a;const c=document,r="ios"===n,i="android"===n,d=o.getNumber("keyboardHeight",290),l=o.getBoolean("scrollAssist",!0),y=o.getBoolean("hideCaretOnScroll",r),g=o.getBoolean("inputBlurring",r),L=o.getBoolean("scrollPadding",!0),f=Array.from(c.querySelectorAll("ion-input, ion-textarea")),v=new WeakMap,S=new WeakMap,b=yield W.K.getResizeMode(),A=function(I){return(a=a||(0,M.Z)(function*(_){yield new Promise(T=>(0,m.c)(_,T));const G=_.shadowRoot||_,w=G.querySelector("input")||G.querySelector("textarea"),C=(0,x.f)(_),Y=C?null:_.closest("ion-footer");if(w){if(C&&y&&!v.has(_)){const T=((e,t,s)=>{if(!s||!t)return()=>{};const o=r=>{(e=>e===e.getRootNode().activeElement)(t)&&B(e,t,r)},n=()=>B(e,t,!1),a=()=>o(!0),c=()=>o(!1);return(0,m.a)(s,"ionScrollStart",a),(0,m.a)(s,"ionScrollEnd",c),t.addEventListener("blur",n),()=>{(0,m.b)(s,"ionScrollStart",a),(0,m.b)(s,"ionScrollEnd",c),t.removeEventListener("blur",n)}})(_,w,C);v.set(_,T)}if("date"!==w.type&&"datetime-local"!==w.type&&(C||Y)&&l&&!S.has(_)){const T=ee(_,w,C,Y,d,L,b,i);S.set(_,T)}}})).apply(this,arguments)};g&&(()=>{let e=!0,t=!1;const s=document;(0,m.a)(s,"ionScrollStart",()=>{t=!0}),s.addEventListener("focusin",()=>{e=!0},!0),s.addEventListener("touchend",c=>{if(t)return void(t=!1);const r=s.activeElement;if(!r||r.matches(O))return;const i=c.target;i!==r&&(i.matches(O)||i.closest(O)||(e=!1,setTimeout(()=>{e||r.blur()},50)))},!1)})();for(const u of f)A(u);c.addEventListener("ionInputDidLoad",u=>{A(u.detail)}),c.addEventListener("ionInputDidUnload",u=>{(u=>{if(y){const I=v.get(u);I&&I(),v.delete(u)}if(l){const I=S.get(u);I&&I(),S.delete(u)}})(u.detail)})})).apply(this,arguments)}}}]);