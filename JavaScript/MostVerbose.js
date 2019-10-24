let Take = {
    The: {
        String: function ( /*string*/ word, callback) {
            return callback(word);
        }
    }
}

let And = {
    Reverse: {
        It: function ( /*string*/ word) {
            return word.split('').reverse().join('')
        }
    }
}

let reversedString = Take.The.String("Hello world", And.Reverse.It);
