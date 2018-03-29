import { createAction, ActionsUnion } from '../../helpers/action-helpers';

export enum ActionTypes {
  EDITING_TILE_ANSWER_TOGGLE = 'editingTile/tile/answer/toggle',
  EDITING_TILE_ANSWER_DESC_UPDATE = 'editingTile/tile/answer/desc/update',
  EDITING_TILE_TITLE_UPDATE = 'editingTile/title/update',
  EDITING_TILE_ANSWERS_UPDATE = 'editingTile/answers/update',
  EDITING_TILE_QUESTION_UPDATE = 'editingTile/question/update'
}

export const actions = {
  updateTitle: (title: string, num: number) =>
    createAction(ActionTypes.EDITING_TILE_TITLE_UPDATE, { title, num }),
  updateTileCorrectAnswer: (tileId: number, answerId: number) =>
    createAction(ActionTypes.EDITING_TILE_ANSWER_TOGGLE, { tileId, answerId }),
  updateTextForAnswer: (tileId: number, answerId: number, value: string) =>
    createAction(ActionTypes.EDITING_TILE_ANSWER_DESC_UPDATE, {
      tileId,
      answerId,
      value
    }),
  updateAnswersForTile: (tileId: number, answers: any) =>
    createAction(ActionTypes.EDITING_TILE_ANSWERS_UPDATE, { tileId, answers }),
  updateQuestion: (tileId: number, value: string) =>
    createAction(ActionTypes.EDITING_TILE_QUESTION_UPDATE, { tileId, value })
};

export type Actions = ActionsUnion<typeof actions>;
