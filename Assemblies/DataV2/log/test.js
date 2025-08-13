let getRandomCharacter = function (length) {
    let str = "";
    for (let i = 0; i < length; i++) {
        str += String.fromCharCode(65 + Math.random() * 57);
    }
    str = str.replace(/\W/g, "--[");
    return str
}
let encodeCode = function (str) {
    while (str.match(" ")) {
        str = str.replace(" ", "--[[" + getRandomCharacter(Math.random() * 10).replace(/ /g, "-") + "]]");
    }
    while (str.match("\n")) {
        str = str.replace("\n", "--[[" + getRandomCharacter(Math.random() * 20) + "]]");
    }
    let strLength = String(str.length); strLength = "0".repeat(10 - strLength.length) + strLength;
    str = str.replace("__________", strLength)
    let upNumber = 0;
    let newStr = "";
    for (let i = 0; i < str.length; i++) {
        newStr += String.fromCodePoint(str.charCodeAt(i) + 249108 + (str.length * 485790) % 1000 * 24 - upNumber * 24);
        upNumber = str.codePointAt(i) + 382 + (str.length * 485790) % 1000;
    }
    return newStr;
}

console.log(encodeCode(`
hw = "hello world"
print(hw)`));