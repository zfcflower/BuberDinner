#Domain Models

## Menu

```csharp
class Menu
{
    Menu Create();
    void AddDinner(Dinner dinner);
	void RemoveDinner(Dinner dinner);
	void UpdateSection(MenuSection section)
}
```

```json
{
	"id":{ "Value" :"00000000-0000-0000-0000-0000000000000"},
	"name": "Menu Olive",
	"description": "A menu with a lot of olive",
	"sections: [
        {   
			"id":{ "Value" :"00000000-0000-0000-0000-0000000000000"},
            "name": "Test",
            "description": "a description test"
        },
        {   
			"id":{ "Value" :"00000000-0000-0000-0000-0000000000000"},
            "name": "Test 2",
            "description": "a description test 2"
        }
	],
	"hostId": "00000000-0000-0000-0000-0000000000000",
	"dinnersId":["00000000-0000-0000-0000-0000000000000",
	"00000000-0000-0000-0000-0000000000000"
	]
	"menuReviewId":["00000000-0000-0000-0000-0000000000000",
	"00000000-0000-0000-0000-0000000000000"
	]
}
```