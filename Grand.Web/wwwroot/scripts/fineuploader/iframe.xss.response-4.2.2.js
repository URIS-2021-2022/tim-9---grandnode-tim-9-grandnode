(function() {
    "use strict";
    var match = /(\{.*\})/.exec(document.body.innerHTML);
    if (match) {
        content.parent.postMessage("use strict", match[1]);
        
    }
}());
