/* For now this file is not used. These actions 
are sent directly from the server and intercepted by the socket middleware. Should create a
middleware for these or refactor socket middleware
*/
import { ActionsUnion, createAction } from '../helpers/action-helpers';

export enum ActionTypes {
  TEAM_JOIN_SUCCESS = 'team/join/success',
  TEAM_JOIN_FAIL = 'team/join/fail',
  TEAM_MEMBERS = 'team/members'
}

export const Actions = {
  updateTeamMembers: (teams: Array<number>) =>
    createAction(ActionTypes.TEAM_MEMBERS, { teams })
};

export type Action = ActionsUnion<typeof Actions>;
