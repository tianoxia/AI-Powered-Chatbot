export const environment = {
  production: false,
  apiUrl: 'https://localhost:7045/api/',
  msalConfig: {
    auth: {
      clientId: 'd29d492d-2c66-4d62-b1a4-97daec7b7f8c',
      authority:
        'https://login.microsoftonline.com/69842ecd-908e-4713-9f15-a976eff83b07',
    },
  },
  apiConfig: {
    scopes: ['api://d29d492d-2c66-4d62-b1a4-97daec7b7f8c/access_as_user'],
    uri: 'https://localhost:7045/api/',
  },
};
