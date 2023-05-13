import requests
import json

response = requests.get('https://api.coindesk.com/v1/bpi/currentprice.json')
response_json = json.loads(response.text)
price = response_json['bpi']['USD']['rate']

print(f'The current Bitcoin price is ${price}')