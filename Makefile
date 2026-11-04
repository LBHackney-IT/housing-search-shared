.PHONY: test

test:
	docker compose build hackney-shared-housing-search-test
	docker compose run --rm hackney-shared-housing-search-test
