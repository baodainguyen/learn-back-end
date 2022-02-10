1. AccountController
    - GET: https://localhost:5001/projectgroup/getuserforedit/accountId/projectGroupId/projectId
2. OrganisationController
    - GET: https://localhost:5001/organisation/getcrmpeople/lang={Language}&projid={projectId}
        * Example: https://localhost:5001/organisation/getcrmpeople/lang=en&projid=62689
    - POST: https://localhost:5001/organisation/getexport/
        * Params: string Ids, long ProjectId
        * Example: { "Ids": "30118, 30119", "ProjectId" : 30339 }

3. PeopleController
    - POST: https://localhost:5001/people/getexport/
        * Params: string PersonIds, long ProjectId
        * Example: { "PersonIds": "30163, 30166", "ProjectId" : 30339 }

4. ProjectGroupController
    - GET: https://localhost:5001/projectgroup/getmemberprojectgroup/accountId/projectGroupId
        * Example: https://localhost:5001/projectgroup/getmemberprojectgroup/1/1 