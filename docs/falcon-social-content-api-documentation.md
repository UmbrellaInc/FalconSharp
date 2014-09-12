# Falcon Social Content API Documentation

> *This is a working document there can we change on field names and more/less fields in some cases, but this should give you a oversight.*

## Authentication

Send `X-Falcon-ApiKey` HTTP header with your API key.

## Methods

### GET /v1/channels

This will return an array of channels from the authorised organisation.

Result: 

	{
		"items": [
			{
				"id" : "id",
				"network" : "facebook",
				"name" : "Some facebook page",
				"status" : "online", 
				"profileImageUrl" : "profileImageUrl",
			}
		]
	}


Value: 

| id              | The Channel ID within Falcon's system |
| network         | The name of the network e.g. facebook, twitter, google+, etc. |
| name            | The Channel Name within Falcon's system |
| state           | The state within Falcon's channel can be `online`, `offline`, `under-deletion` |
| profileImageUrl | The URL to the channels profile image as a PNG or JPEG |


### GET /v1/channels/{channelId}/content

This will return an array of channels from the authorised organisation.

Query parameters:

| since  | date time in `yyyy-MM-dd'T'HH:mm:ss.SSSZZ` format |
| until  | date time in `yyyy-MM-dd'T'HH:mm:ss.SSSZZ` format |
| limit  | limits number of results - default is `50` |
| offset | the starting point with the list. |

Result: 

	{
		"items": [
			{
				"id": "id",
				"network": "network",
				"status": "status",
				"createDate": "2014-01-23T16:30:13.000Z",
				"updateDate": "2014-01-27T15:54:59.000Z",
				"channelId": "channelId",
				"caption": "",
				"description": "",
				"name": "",
				"message": "message",
				"link": "link",
				"picture": "picture",
				"type": "photo",
				"tags":["tag1", “tag2”],
				"stats": {
				"post_comments": 4,
				"post_shares": 0,
				"post_likes": 1,
				"post_impressions_unique": 0,
				"post_engaged_users": 0
			}
		}
	]

Value:
 
| id          | The Content ID within Falcon's system |
| network     | The name of the network ex. facebook, twitter, google+, and etc. |
| status      | Content status: deleted, unread, vanished, read |
| createDate  | The Creation Date within Falcon’s system of the content |
| updateDate  | The last Updated Date within Falcon’s system of the content |
| caption     | This value can be optional is the caption of a link post  (Facebook) |
| description | This value can be optional is the description of a link post  (Facebook) |
| name        | This value can be optional is the name of a link post (Facebook) |
| message     | Post's message body |
| link        | This value can be optional is the URL of a link post (Facebook) |
| type        | The type of content ex. photo |
| tags        | This is a list of tagged |
| stats       | The states on the content from the network.
Facebook
* "post_comments": 4,
* "post_shares": 0,
* "post_likes": 1,
* "post_impressions_unique": 0,
* "post_engaged_users": 0
Twitter
* "tweet_retweets":"0"
* "tweet_favorites":"0" |
