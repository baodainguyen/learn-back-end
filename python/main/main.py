from flask import Flask, request, jsonify, Response
import json
from flask_cors import CORS
import mysql.connector

app = Flask(__name__)
CORS(app)

db = mysql.connector.connect(
                user='root',
                passwd='root',
                host='db',
                database='data_ms'
        )


@app.route('/')
def index():
        output = []
        try:
                sqlstr = "SELECT * FROM products_product"
                cur = db.cursor()
                cur.execute(sqlstr)
                products = cur.fetchall()
                
                for p in products:
                        output.append( 
                                {
                                "id":p[0],
                                "title":p[1],
                                "image":p[2],
                                "likes":p[3]
                                })

        except Exception as e:
                print("error in SQL: "),e
        finally:
                db.close()
        return jsonify(results=output)

if __name__ == "__main__":
    app.run(debug=True, host='0.0.0.0')
