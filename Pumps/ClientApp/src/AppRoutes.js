import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
/*import {CreateNewPump } from "./components/CreateNewPump"*/

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
  path: '/counter',
  element: <Counter />
    },
  //{
  //    path: '/create-new-pump',
  //    element: <CreateNewPump/>

  //},

  {
    path: '/fetch-data',
    requireAuth: true,
    element: <FetchData />
  },
  ...ApiAuthorzationRoutes
];

export default AppRoutes;
