from flask import Flask, request, jsonify
from flask_cors import CORS
from context import config

app = Flask(__name__)
CORS(app)

dbContext = config(app)

@app.route('/')
def index():        
        oupt = dbContext.getProducts()
        return jsonify(results=oupt)

@app.route('/<int:id>', methods=['GET'])
def getBy(id):
        product = dbContext.getProduct(id)
        return jsonify(results=product)

@app.route('/<int:id>', methods=['PUT'])
def like(id):
        product = dbContext.updateLike(id)
        return jsonify(results=product)

if __name__ == "__main__":
    app.run(debug=True, host='0.0.0.0')
